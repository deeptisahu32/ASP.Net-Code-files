using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Electricity_Prj.Models
{
    public class ElectricityBill
    {

        private string consumer_number;
        private string consumerName;
        private int unitsConsumed;
        private double billAmount;
        private DateTime createdAt;


        public string ConsumerNumber
        {

            get => consumer_number;
            set
            {
                // Normalize input
                var v = value?.Trim().ToUpperInvariant();

                // Validate: EB + 5 digits (e.g., EB11389)
                if (string.IsNullOrWhiteSpace(v) || !Regex.IsMatch(v, @"^EB\d{5}$"))
                {
                    throw new FormatException("Invalid Consumer Number");
                }
                consumer_number = v;
            }

        }

        public string ConsumerName
        {
            get => consumerName;
            set => consumerName = value?.Trim();
        }

        public int UnitsConsumed
        {
            get => unitsConsumed;
            set => unitsConsumed = value;
        }


        public double BillAmount
        {
            get => billAmount;
            set => billAmount = value;
        }


        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }


    }
}