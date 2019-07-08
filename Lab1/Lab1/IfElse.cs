using System;

namespace Lab1
{
    public class IfElse
    {
        public void ExploreIfElse()
        {
            string department = "CSE";

            if (department == "EEE")
            {
                Console.WriteLine("Hello EEE");
            }
            else if (department == "CSE")
            {
                Console.WriteLine("Hello CSE");
            }
            else
            {
                Console.WriteLine("Other Department!");
            }

            // Ternary operation

            string message = department == "CSE" ? "Hello CSE" : "Other Department";

            Console.WriteLine("From ternaary operation. " + message);
            Console.WriteLine("------------------------------------");

            // Special Case for null

            string name = "";

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name is Empty/Null");
            }
            else
            {
                Console.WriteLine($"Name is {name}");
            }

            // Null check using ternary operation

            name = String.IsNullOrWhiteSpace(name) ? "Empty/Null" : name;
            Console.WriteLine("Ternary => Name is " + name);

            // Null coalescing operator (?? operator)

            name = name ?? "Empty/Null";
            Console.WriteLine($"Null Coalescing => {name}");

            Console.ReadLine();
        }
    }
}
