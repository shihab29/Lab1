using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Lists
    {
        public void ExploreLists()
        {
            var deptNames = new List<string>() { "CSE", "EEE", "ME" };

            Console.WriteLine("LowerCase: ");

            foreach (var deptName in deptNames)
            {
                Console.Write(deptName.ToLower() + "\n");
            }

            // Add item into the list

            var letters = new List<string>();

            Console.WriteLine("After adding letters: ");

            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            letters.Add("D");

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("After removing letters: ");

            // Remove Item

            letters.Remove("C");
            letters.Remove("E");

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }

            // Append items at the beginning of a list

            var newLetters = new List<string>() { "P", "Q", "R" };

            letters.Insert(0, "Z");
            letters.InsertRange(0, newLetters);

            Console.WriteLine("After appending at the beginning of a list: ");

            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }

            // sort a list

            letters.Sort();

            Console.WriteLine("After sorting the list: ");

            for (int i = 0; i < letters.Count; i++)
            {
                Console.WriteLine(letters[i]);
            }

            Console.ReadLine();

            // Challenge: Solve the fibonacciNumbers problem using list.
        }
    }
}
