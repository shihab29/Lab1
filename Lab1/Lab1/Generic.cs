using System;

namespace Lab1
{
    public class Generic
    {
        public void ExploreGeneric()
        {
            Console.WriteLine(Sum<int>(1, 2));
            Console.WriteLine(Sum<double>(2.9, 3.9));
            Console.WriteLine(Sum<string>("10", "20"));

            Console.ReadLine();
        }

        public static double Sum<T>(T num1, T num2)
        {
            double number1 = Convert.ToDouble(num1);
            double number2 = Convert.ToDouble(num2);

            return number1 + number2;
        }
    }
}
