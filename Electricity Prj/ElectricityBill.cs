using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Electricity_Prj.Models
{
    public class ElectricityBill
    {

        private string consumer_number;
        private string consumerName;
        private int unitsConsumed;
        private double billAmount;


        public string ConsumerNumber
        {
            get => consumer_number;
            set => consumer_number = value;
        }

        public string ConsumerName
        {
            get => consumerName;
            set => consumerName = value;
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



    }
}