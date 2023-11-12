using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace b209_list_homework_alper_sahin
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();


        public Form1()
        {
            InitializeComponent();
            dataGridViewSettings();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                dataGridList.Columns.Add(button);
                button.Name = "button";
                button.Text = "View";
                button.HeaderText = "Details";
                button.UseColumnTextForButtonValue = true;
            }
            students.Add(new Student("1.", "Ahmet", "Yýlmaz", 21, "Kayseri", "CE", 8.57, true, 2002, Properties.Resources._1));
            students.Add(new Student("2.", "Albert", "Greg", 22, "Tetovo", "IE", 9, true, 2001, Properties.Resources._2));
            students.Add(new Student("3.", "Mehmet", "Yýlmaz", 20, "Istanbul", "CE", 5, true, 2003, Properties.Resources._3));
            students.Add(new Student("4.", "Lionel", "Messi", 25, "Skopje", "CE", 3.54, false, 1998, Properties.Resources._4));
            students.Add(new Student("5.", "Sandra", "Borova", 28, "London", "ARCH", 6.57, false, 1995, Properties.Resources._5));

            PopulateDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridList.Columns["button"].Index && e.RowIndex >= 0)
            {
                int selectedStudentIndex = e.RowIndex;
                if (selectedStudentIndex < students.Count)
                {
                   
                    Form2 f2 = new Form2(students[selectedStudentIndex]);
                    f2.ShowDialog();
                }
            }



        }

        private void PopulateDataGridView()
        {
            foreach (var student in students)
            {
                dataGridList.Rows.Add(student.StudentNumber, student.Name, student.Surname, student.Year, student.City, student.Department);
            }
        }

        private void dataGridViewSettings()
        {
            dataGridList.ReadOnly = true;
            dataGridList.AllowUserToDeleteRows = false;
            dataGridList.ColumnCount = 6;
            dataGridList.Columns[0].Name = "Student No";
            dataGridList.Columns[1].Name = "Name";
            dataGridList.Columns[2].Name = "Surname";
            dataGridList.Columns[3].Name = "Year";
            dataGridList.Columns[4].Name = "City";
            dataGridList.Columns[5].Name = "Department";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                dataGridList.Rows.Clear();
                foreach (var student in students)
                {
                    if (student.Name.Contains(searchText))
                    {
                        dataGridList.Rows.Add(student.StudentNumber, student.Name, student.Surname, student.Year, student.City, student.Department);
                    }
                }
            }
            else
            {
                dataGridList.Rows.Clear(); 

                PopulateDataGridView();
            }
        }
    }
}