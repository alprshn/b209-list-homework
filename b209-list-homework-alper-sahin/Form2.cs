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
                studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
                studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
                studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
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
                activeStudent.ForeColor= Color.Red;
            }


            studentPhoto.Image = new System.Drawing.Bitmap(selectedStudent.Image);
        }

        private void dataGridTranscript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        private void PopulateDataGridView()
        {
            foreach (var studentTranscripts in studentTranscript)
            {
                // Add rows to the DataGridView based on the student data
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
