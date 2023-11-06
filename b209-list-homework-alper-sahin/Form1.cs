using System.Data;
using System.Windows.Forms;

namespace b209_list_homework_alper_sahin
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();


        public Form1()
        {
            InitializeComponent();

            //dataGridList.RowHeadersVisible = false;
            //dataGridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            //dataGridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridList.RowsDefaultCellStyle = dataGridList.DefaultCellStyle;
            dataGridViewSettings();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                dataGridList.Columns.Add(button);

                button.Name = "button";
                button.Text = "View";
                button.HeaderText = "Details";
                button.UseColumnTextForButtonValue = true; //dont forget this line
            }

            students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE"));
            students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE"));
            students.Add(new Student("1", "Mehmet", "Yýlmaz", 1998, "Kayseri", "CE"));


            PopulateDataGridView();

            //Button buttonDetails = new Button();
            //students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE", buttonDetails));
            //students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE", buttonDetails));
            //students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE", buttonDetails));
            //students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE", buttonDetails));
            //students.Add(new Student("1", "Ahmet", "Yýlmaz", 1998, "Kayseri", "CE", buttonDetails));
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PopulateDataGridView()
        {
            foreach (var student in students)
            {
                // Add rows to the DataGridView based on the student data
                dataGridList.Rows.Add(student.StudentNumber, student.Name, student.Surname, student.Year, student.City, student.Department);
            }
        }

        private void dataGridViewSettings()
        {
            dataGridList.ReadOnly = true;
            dataGridList.AllowUserToDeleteRows = false;
            dataGridList.ColumnCount = 7;
            dataGridList.Columns[0].Name = "Student No";
            dataGridList.Columns[1].Name = "Name";
            dataGridList.Columns[2].Name = "Surname";
            dataGridList.Columns[3].Name = "Year";
            dataGridList.Columns[4].Name = "City";
            dataGridList.Columns[5].Name = "Department";
            dataGridList.Columns[6].Name = "Details";


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
                dataGridList.Rows.Clear(); // Clear the rows before repopulating with full data

                // If the search text is empty, repopulate the DataGridView with all data
                PopulateDataGridView();
            }
        }
    }
}