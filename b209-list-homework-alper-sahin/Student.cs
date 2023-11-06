using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace b209_list_homework_alper_sahin
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public string City { get; set; }
        public string Department { get; set; }

        public Student(string number, string name, string surname, int year, string city, string department)
        {
            StudentNumber = number;
            Name = name;
            Surname = surname;
            Year = year;
            City = city;
            Department = department;
            
        }
    }
}
