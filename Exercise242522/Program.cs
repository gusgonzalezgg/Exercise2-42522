using System;

namespace Exercise242522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the radius of your circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine(area);

            Class2.SimpleMath();


        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }



    }
}

