using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class StudentCredentials
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearLvl { get; set; }
        public string course { get; set; }
        public string section { get; set; }

        public StudentCredentials(string firstName, string lastName, int yearLvl, string course, string section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearLvl = yearLvl;
            this.course = course;
            this.section = section;
        }

        public void displayCredentials()
        {
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Year Level: {yearLvl}");
            Console.WriteLine($"Course or Program: {course}");
            Console.WriteLine($"Section: {section}");
        }
    }
}
