using Electricity_Prj.Data;
using Electricity_Prj.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Electricity_Prj.Services
{
    public class ElectricityBoard
    {
        private readonly DBHandler db;

        public ElectricityBoard()
        {
            db = new DBHandler();
        }

        // ---- Validation: Consumer Number format (EB + 5 digits) ----
        private void ValidateConsumerNumber(string consumerNumber)
        {
            var isValid = Regex.IsMatch(consumerNumber ?? "", @"^EB\d{5}$", RegexOptions.IgnoreCase);
            if (!isValid)
            {
                throw new FormatException("Invalid Consumer Number");
            }
        }

        // ---- Bill Calculation (slab-wise) ----
        public void CalculateBill(ElectricityBill ebill)
        {
            // Normalize & validate CN
            ebill.ConsumerNumber = ebill.ConsumerNumber?.Trim().ToUpperInvariant();
            ValidateConsumerNumber(ebill.ConsumerNumber);

            int units = ebill.UnitsConsumed;
            double amount = 0;

            if (units <= 100)
            {
                amount = 0;
            }
            else if (units > 100 && units <= 300)
            {
                amount = (units - 100) * 1.5;
            }
            else if (units > 300 && units <= 600)
            {
                amount = (200 * 1.5) + ((units - 300) * 3.5);
            }
            else if (units > 600 && units <= 1000)
            {
                amount = (200 * 1.5) + (300 * 3.5) + ((units - 600) * 5.5);
            }
            else
            {
                amount = (200 * 1.5) + (300 * 3.5) + (400 * 5.5) + ((units - 1000) * 7.5);
            }

            ebill.BillAmount = amount;
        }

        // ---- EnsureConsumer: find or create consumer; enforce name consistency ----
        private int EnsureConsumer(string consumerNumber, string consumerName, SqlConnection con)
        {
            // Find existing consumer by number
            using (var find = con.CreateCommand())
            {
                find.CommandText = @"
                    SELECT consumer_id, consumer_name
                    FROM dbo.Consumers
                    WHERE consumer_number = @cn;";
                find.Parameters.AddWithValue("@cn", consumerNumber);

                using (var r = find.ExecuteReader())
                {
                    if (r.Read())
                    {
                        int cid = r.GetInt32(0);
                        string existingName = r.GetString(1);

                        // Case-insensitive compare, trim whitespace
                        if (!string.Equals(existingName?.Trim(), consumerName?.Trim(),
                                           StringComparison.OrdinalIgnoreCase))
                        {
                            throw new InvalidOperationException(
                                $"Consumer Number '{consumerNumber}' is already registered to '{existingName}'. " +
                                $"Please use the same name or a different consumer number.");
                        }
                        return cid; // Same name ⇒ OK
                    }
                }
            }

            // Not found ⇒ create new consumer
            using (var ins = con.CreateCommand())
            {
                ins.CommandText = @"
                    INSERT INTO dbo.Consumers(consumer_number, consumer_name)
                    VALUES(@cn, @name);
                    SELECT SCOPE_IDENTITY();";
                ins.Parameters.AddWithValue("@cn", consumerNumber);
                ins.Parameters.AddWithValue("@name", consumerName?.Trim());

                return Convert.ToInt32(ins.ExecuteScalar());
            }
        }

        // ---- AddBill: link to consumer_id and insert a bill row ----
        public void AddBill(ElectricityBill ebill)
        {
            // Normalize inputs
            ebill.ConsumerNumber = ebill.ConsumerNumber?.Trim().ToUpperInvariant();
            ebill.ConsumerName = ebill.ConsumerName?.Trim();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                // 1) Ensure consumer exists & name matches; get consumer_id
                int consumerId = EnsureConsumer(ebill.ConsumerNumber, ebill.ConsumerName, con);

                // 2) Insert bill row (history allowed for same consumer+name)
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO dbo.ElectricityBill
                            (consumer_id, consumer_number, consumer_name, units_consumed, bill_amount)
                        VALUES
                            (@cid, @cn, @name, @units, @amt);";

                    cmd.Parameters.AddWithValue("@cid", consumerId);
                    cmd.Parameters.AddWithValue("@cn", ebill.ConsumerNumber);
                    cmd.Parameters.AddWithValue("@name", ebill.ConsumerName);
                    cmd.Parameters.AddWithValue("@units", ebill.UnitsConsumed);
                    cmd.Parameters.AddWithValue("@amt", ebill.BillAmount);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ---- Retrieve: last N bills with date ----
        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            var list = new List<ElectricityBill>();

            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = con.CreateCommand())
            {
                // Time-based latest (requires created_at in table)
                cmd.CommandText = @"
                    SELECT TOP (@n)
                           consumer_number, consumer_name, units_consumed, bill_amount, created_at
                    FROM dbo.ElectricityBill
                    ORDER BY created_at DESC;";

                cmd.Parameters.Add("@n", SqlDbType.Int).Value = num;

                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var eb = new ElectricityBill
                        {
                            ConsumerNumber = rdr.GetString(0),
                            ConsumerName = rdr.GetString(1),
                            UnitsConsumed = rdr.GetInt32(2),
                            BillAmount = rdr.GetDouble(3),
                            CreatedAt = rdr.GetDateTime(4)
                        };
                        list.Add(eb);
                    }
                }
            }

            return list;
        }

        // ---- Retrieve: by Consumer Number (exact match) ----
        public List<ElectricityBill> GetBillsByConsumerNumber(string consumerNumber)
        {
            var list = new List<ElectricityBill>();
            string cn = (consumerNumber ?? "").Trim().ToUpperInvariant(); // normalize

            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT consumer_number, consumer_name, units_consumed, bill_amount, created_at
            FROM dbo.ElectricityBill
            WHERE consumer_number = @cn
            ORDER BY created_at DESC;";

                cmd.Parameters.Add("@cn", SqlDbType.VarChar, 20).Value = cn;

                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new ElectricityBill
                        {
                            ConsumerNumber = rdr.GetString(0),
                            ConsumerName = rdr.GetString(1),
                            UnitsConsumed = rdr.GetInt32(2),
                            BillAmount = rdr.GetDouble(3),
                            CreatedAt = rdr.GetDateTime(4)
                        });
                    }
                }
            }

            return list;
        }

    }
}
