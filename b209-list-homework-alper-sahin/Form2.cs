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

        public Form2()
        {
            InitializeComponent();
            dataGridViewSettings();
            studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
            studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
            studentTranscript.Add(new StudentTranscript("CE-102", 2019, "B"));
            PopulateDataGridView();
        }

        private void dataGridTranscript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
        
        }
        private void PopulateDataGridView()
        {
            foreach (var studentTranscripts in studentTranscript)
            {
                // Add rows to the DataGridView based on the student data
                dataGridTranscript.Rows.Add(studentTranscripts.Course,studentTranscripts.Year,studentTranscripts.Grade);
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
    }
}
