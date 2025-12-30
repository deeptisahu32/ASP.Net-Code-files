using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_n_Enum
{
    enum cities { Bangalore=1 ,Agra=0,Chennai=2,Vizag=4,Hydrabad=3}
    internal class enumEx
    {
        public static void EnumOps()
        {
            Console.WriteLine("Hi Enums");
            foreach(int c in Enum.GetValues(typeof(cities)))
            {
                Console.WriteLine(c);

                if (c == 1) Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "Is a Garden city");
                else if (c == 2) Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "Is a Temple city");
            }
        }
       
    }

}
