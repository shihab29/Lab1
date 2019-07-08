using System;

namespace Lab1
{
    public class ValueVsReference
    {
        public void ExploreValueVsReferenceType()
        {
            int num = 100;
            var numbers = new int[] { 1, 2, 3, 4 };

            ValueType(num);
            ReferenceType(numbers);

            Console.WriteLine("In the main loop. Num: " + num);
            Console.WriteLine("In the main loop. Numbers: ");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }



            Console.ReadLine();
        }

        public void ValueType(int num)
        {
            num++;
            Console.WriteLine("Inside Value Type. Numeber: " + num);
        }

        public void ReferenceType(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
            }

            Console.WriteLine("Inside Reference Type. Numbers: ");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
