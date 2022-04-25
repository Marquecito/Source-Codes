using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");

            int limitOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Enter the credentials of the students: ");
            Console.WriteLine("");

            var studentCredentials = new StudentCredentials[limitOfArray];
            foreach (int i in Enumerable.Range(0, limitOfArray))
            {
               
                Console.WriteLine($"Student # {i + 1}");
                Console.WriteLine("");
                Console.Write("First Name: ");
                var firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                var lastName = Console.ReadLine();
                Console.Write("Year Level: ");
                var yearLvl = Convert.ToInt32(Console.ReadLine());
                Console.Write("Course or Program: ");
                var course = Console.ReadLine();
                Console.Write("Section: ");
                var section = Console.ReadLine();

                studentCredentials[i] = new StudentCredentials(firstName, lastName, yearLvl, course, section);
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("Students Entered: ");
            Console.WriteLine("");

            for (int i = 0; i < studentCredentials.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Student # {i + 1}");
                studentCredentials[i].displayCredentials();
                Console.WriteLine("");

            }
        }
    }
}
