
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

        private void ValidateConsumerNumber(string consumerNumber)
        {
            var isValid = Regex.IsMatch(consumerNumber ?? "", @"^EB\d{5}$");
            if (!isValid)
            {
                throw new FormatException("Invalid Consumer Number");
            }
        }



        public void CalculateBill(ElectricityBill ebill)
        {
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


        public void AddBill(ElectricityBill ebill)
        {
            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
                INSERT INTO ElectricityBill (consumer_number, consumer_name, units_consumed, bill_amount)
                VALUES (@consumer_number, @consumer_name, @units_consumed, @bill_amount);";
                cmd.Parameters.AddWithValue("@consumer_number", ebill.ConsumerNumber);
                cmd.Parameters.AddWithValue("@consumer_name", ebill.ConsumerName);
                cmd.Parameters.AddWithValue("@units_consumed", ebill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@bill_amount", ebill.BillAmount);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            var list = new List<ElectricityBill>();

            using (SqlConnection con = db.GetConnection())
            using (SqlCommand cmd = con.CreateCommand())
            {
                // Retrieve LAST N records by descending primary key 'id' (or fallback order)
                cmd.CommandText = @"
                SELECT TOP (@n) consumer_number, consumer_name, units_consumed, bill_amount
                FROM ElectricityBill
                ORDER BY id DESC;";

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
                            BillAmount = rdr.GetDouble(3)
                        };
                        list.Add(eb);
                    }
                }
            }

            return list;
        }
    }
}
