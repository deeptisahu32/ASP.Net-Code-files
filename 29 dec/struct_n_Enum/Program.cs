using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_n_Enum
{
    internal class Program
    {
        // in struct no chnage in reaassigning value but in class whatever i reassign it will change evrerywhere

        //struct Student
        //{
        //    public int v1;
        //    public float v2;
        //}
        class Student
        {
            public int v1;
            public float v2;
        }
        class TestStudent
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.v1 = 10; 
                s.v2 = 20;
                Console.WriteLine(s.v1 + s.v2);

                Student s2 = new Student();
                s2 = s;
                Console.WriteLine($" the s2 has : {s2.v1 + s2.v2}");

                s.v1 = 50; // assigning the value of s to s2 , only s value will change
                Console.WriteLine("After reassigning : " + s.v1 + s.v2);
                Console.WriteLine("After reassigning : " + s2.v1+s2.v2);

                s2.v2 = 100;
                Console.WriteLine("After reassigning : " + s.v1 + s.v2);
                Console.WriteLine("After reassigning : " + s2.v1 + s2.v2);

                Console.ReadLine();


            }
        }
       
    }
}
