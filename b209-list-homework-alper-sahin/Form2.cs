using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b209_list_homework_alper_sahin
{
    public partial class Form2 : Form
    {
        List<StudentTranscript> studentTranscript = new List<StudentTranscript>();
        private Student selectedStudent;


        public Form2(Student student)
        {
            InitializeComponent();
            dataGridViewSettings();


            selectedStudent = student;

            if (selectedStudent.StudentNumber == "1.")
            {
                studentTranscript.Add(new StudentTranscript("CE-102", 2020, "B"));
                studentTranscript.Add(new StudentTranscript("CE-432", 2020, "C"));
                studentTranscript.Add(new StudentTranscript("IE-102", 2020, "B"));
            }
            if (selectedStudent.StudentNumber == "2.")
            {
                studentTranscript.Add(new StudentTranscript("CE-323", 2018, "A"));
                studentTranscript.Add(new StudentTranscript("IE-102", 2019, "A"));
                studentTranscript.Add(new StudentTranscript("CE-102", 2018, "B"));
            }
            if (selectedStudent.StudentNumber == "3.")
            {
                studentTranscript.Add(new StudentTranscript("CE-134", 2019, "A"));
                studentTranscript.Add(new StudentTranscript("IE-102", 2020, "B"));
                studentTranscript.Add(new StudentTranscript("CE-102", 2019, "C"));
            }
            if (selectedStudent.StudentNumber == "4.")
            {
                studentTranscript.Add(new StudentTranscript("CE-102", 2018, "B"));
                studentTranscript.Add(new StudentTranscript("CE-432", 2018, "D"));
                studentTranscript.Add(new StudentTranscript("CE-107", 2018, "B"));
            }
            if (selectedStudent.StudentNumber == "5.")
            {
                studentTranscript.Add(new StudentTranscript("IE-102", 2021, "B"));
                studentTranscript.Add(new StudentTranscript("CE-102", 2021, "F"));
                studentTranscript.Add(new StudentTranscript("CE-123", 2019, "B"));
            }


            DisplayReceivedStudents();

            PopulateDataGridView();
        }

        private void DisplayReceivedStudents()
        {
            nameStudent.Text = selectedStudent.Name;
            birthStudent.Text = selectedStudent.Birth.ToString();
            idStudent.Text = selectedStudent.StudentNumber.ToString();
            gpaStudent.Text = selectedStudent.GPA.ToString();
            if (selectedStudent.Status == true)
            {
                activeStudent.Text = "Active";
                activeStudent.ForeColor = Color.Green;
            }
            else
            {
                activeStudent.Text = "Inactive";
                activeStudent.ForeColor = Color.Red;
            }


            studentPhoto.Image = selectedStudent.Image;
        }

        private void dataGridTranscript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        private void PopulateDataGridView()
        {
            foreach (var studentTranscripts in studentTranscript)
            {
                dataGridTranscript.Rows.Add(studentTranscripts.Course, studentTranscripts.Year, studentTranscripts.Grade);
            }
        }

        private void dataGridViewSettings()
        {
            dataGridTranscript.ReadOnly = true;
            dataGridTranscript.AllowUserToDeleteRows = false;
            dataGridTranscript.ColumnCount = 3;
            dataGridTranscript.Columns[0].Name = "Course";
            dataGridTranscript.Columns[1].Name = "Year";
            dataGridTranscript.Columns[2].Name = "Grade";



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
