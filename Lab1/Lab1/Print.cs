using System;

namespace Lab1
{
    public class Print
    {
        public void DoPrint()
        {
            string department = "CSE";

            Console.WriteLine("Hello " + department);

            // Composite Format String

            Console.WriteLine("Hello {0}", department);

            // String Interpolation

            Console.WriteLine($"hello {department}");

            // Verbatim Identifier

            string filename1 = @"c:\documents\files\u0066.txt";
            string filename2 = "c:\\documents\\files\\u0066.txt";
            string quote = @"He said, ""this is the last chance""";

            Console.WriteLine(filename1);
            Console.WriteLine(filename2);
            Console.WriteLine(quote);

            Console.ReadLine();
        }
    }
}
