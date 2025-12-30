using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_n_Enum
{
    public interface IShape
    {
        double GetArea();
    }
    //public struct Rectangle : IShape  // IN STRUCT WE CAN NOT INHERITENT CLASS
    //{
    //    public double Breadth {  get; set; }
    //    public double Length { get; set; }

    //    public Rectangle(double l, double b)
    //    {
    //        Length = l;
    //        Breadth = b;
    //    }

    //    public double GetArea()
    //    {
    //        return Length * Breadth;
    //    }
    //}
    public class Rectangle : StructEx2,IShape // in class we can inheritent class and intershPE BOTH
    {
        public double Breadth { get; set; }
        public double Length { get; set; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public double GetArea()
        {
            return Length * Breadth;
        }
    }
    public class StructEx2
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5.0, 4.0);
            double area = r.GetArea();
            Console.WriteLine("Area of rectangle : " + area);


            // calling enumEx class

            enumEx.EnumOps();
            Console.ReadLine();
        }
       
    }
}
