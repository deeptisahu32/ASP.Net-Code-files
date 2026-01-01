using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Electricity_Prj.Services
{
    public class Billvalidator
    {
        public string ValidateUnitsConsumed(int unitsConsumed)
        {
            return (unitsConsumed < 0) ? "Given units is invalid" : string.Empty;
        }

    }
}