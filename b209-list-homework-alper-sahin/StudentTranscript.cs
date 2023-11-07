using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b209_list_homework_alper_sahin
{
    public class StudentTranscript
    {
        public string Course { get; set; }
        public int Year { get; set; }
        public string Grade { get; set; }

        public StudentTranscript(string course, int year, string grade)
        {
            Course = course;
            Year = year;
            Grade = grade;

        }
    }
}
