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

            string resimYolu = "C:\\Path\\To\\YourImage.jpg"; // Resmin dosya yolunu doðru þekilde güncelleyi
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            students.Add(new Student("1.", "Ahmet", "Yýlmaz", 21, "Kayseri", "CE", 8.57 ,true,2002, path + @"\avatar\1.png"));
            students.Add(new Student("2.", "Albert", "Greg", 22, "Tetovo", "IE", 9 , true,2001,""));
            students.Add(new Student("3.", "Mehmet", "Yýlmaz", 20, "Istanbul", "CE", 5, true, 2003, ""));
            students.Add(new Student("4.", "Lionel", "Messi", 25, "Skopje", "CE", 3.54, false, 1998, ""));
            students.Add(new Student("5.", "Sandra", "Borova", 28, "London", "ARCH", 6.57, false, 1995, ""));


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
            if (e.ColumnIndex == dataGridList.Columns["button"].Index && e.RowIndex >= 0)
            {
                int selectedStudentIndex = e.RowIndex;
                if (selectedStudentIndex < students.Count)
                {
                    // Öðrencinin detaylarýný göstermek için Form2'yi oluþturun ve gösterin
                    Form2 f2 = new Form2(students[selectedStudentIndex]);
                    f2.ShowDialog();
                }
            }

           

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
                dataGridList.Rows.Clear(); // Clear the rows before repopulating with full data

                // If the search text is empty, repopulate the DataGridView with all data
                PopulateDataGridView();
            }
        }
    }
}