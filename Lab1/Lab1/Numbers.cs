using System;

namespace Lab1
{
    public class Numbers
    {
        public void PlayWithNumbers()
        {
            int max = Int32.MaxValue;
            int min = Int32.MinValue;

            Console.WriteLine($"Min value: {min} and Max value {max}");
            Console.WriteLine($"Min value: {min - 1} and Max value {max + 1}");

            // Type Casting

            int integerNumber = 10;
            double doubleNumber = 10.5;

            Console.WriteLine("Int to Double Conversion: " + Convert.ToDouble(integerNumber));
            Console.WriteLine("Double to Int Conversion: " + Convert.ToInt32(doubleNumber));

            // Calculate Area of a Circle

            double radius = 2.5;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area of the circle: {area}");

            Console.ReadLine();
        }
    }
}
