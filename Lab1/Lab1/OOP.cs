using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class OOP : IOOP
    {
        public void StudentInfo()
        {
            var studentList = new List<Student>()
            {
                new Student() {Name = "Shibli", ID=27, Section="A"},
                new Student() {Name = "Shatu", ID=30, Section="A"},
                new Student() {Name = "Abir", ID=59, Section="B"}
            };

            studentList.Add(new Student() { Name = "Arony", ID = 67, Section = "B" });
            studentList.Add(new Student() { Name = "Ishti", ID = 39, Section = "A" });

            // Count total number of students in Section A and B

            int countA = 0, countB = 0;

            foreach (var student in studentList)
            {
                if (student.Section == "A")
                {
                    countA++;
                }
                else if (student.Section == "B")
                {
                    countB++;
                }
            }

            Console.WriteLine($"Total Students in A: {countA}");
            Console.WriteLine($"Total Students in B: {countB}");

            // LINQ(Language Integrated Query) Query. Very Basic IDEA!!! 

            countA = 0;
            countB = 0;

            countA = studentList.Where(m => m.Section == "A").Count();
            countB = studentList.Where(m => m.Section == "B").Count();

            Console.WriteLine($"Using LINQ");
            Console.WriteLine($"Total Students in A: {countA}");
            Console.WriteLine($"Total Students in B: {countB}");

            // get the Name and section whose ID are odd.

            var oddNameAndSectionList = studentList.Where(m => m.ID % 2 != 0)
                                                   .Select(x => new
                                                   {
                                                       x.Name,
                                                       x.Section
                                                   })
                                                   .ToList();

            foreach (var item in oddNameAndSectionList)
            {
                Console.WriteLine($"Name: {item.Name} and Section: {item.Section}");
            }

            Console.ReadLine();
        }
    }
}
