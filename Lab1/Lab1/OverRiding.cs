﻿using System;

namespace Lab1
{
    public class OverRiding
    {
        public void ExploreOverRiding()
        {
            var result = Sum(10, 20);

            Console.WriteLine("Before Method OverRiding: " + result);
            Console.ReadLine();
        }

        public virtual int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
