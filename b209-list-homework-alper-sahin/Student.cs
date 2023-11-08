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
        public double GPA { get; set; }
        public bool Status { get; set; }
        public int Birth { get; set; }
        public string Image { get; set; }


        public Student(string number, string name, string surname, int year, string city, string department,double gpa, bool status, int birth,  string image)
        {
            StudentNumber = number;
            Name = name;
            Surname = surname;
            Year = year;
            City = city;
            Department = department;
            GPA = gpa;
            Status = status;
            Birth = birth;
            Image = image;  
        }
    }
}
