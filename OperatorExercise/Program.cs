using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4);
            {
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            }
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalculateRadius(radius);
            Console.WriteLine($"The area of your circle is {areaOfCircle}");
            
        }
        public static double CalculateRadius(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }


}
