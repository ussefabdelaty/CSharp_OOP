using System;

namespace Multi_CAst_Del
{
    internal class Program
    {
        //declare delegate 
        //the parameters of the delegeta must be the same type of the method 
        public delegate void RecDelegate(decimal width, decimal height);
        static void Main(string[] args)
        {
            var cal = new RectangleHelper();
            //cal.GetArea(10, 5);
            //cal.Getperimeter(10, 5);   

            RecDelegate rec = cal.GetArea;
            rec += cal.Getperimeter;
            rec(10, 5);

            Console.WriteLine("after unsubscribing");

            rec -= cal.Getperimeter;

            rec(10, 5);

            Console.ReadKey();
        }
    }
    public class RectangleHelper
    {
        //for calculate area
        public void GetArea(decimal width , decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area = {width} x {height}= {result}");
        }

        //for calculate the perimeter
        public void Getperimeter(decimal width, decimal height)
        {
            var result = 2*(width + height);
            Console.WriteLine($"perimeter = 2 x ({width} +{height})= {result}");
        }
    }
}