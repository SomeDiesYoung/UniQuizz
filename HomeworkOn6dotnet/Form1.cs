namespace HomeworkOn6dotnet
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            gpaComboBox.Items.Add("0.0");
            gpaComboBox.Items.Add("1.0");
            gpaComboBox.Items.Add("2.0");
            gpaComboBox.Items.Add("3.0");
            gpaComboBox.Items.Add("4.0");
        }

        private int incrementedId = 1;

        private void RefreshStudentGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
        private void IdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDateInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = firstNameInput.Text;
                string lastName = lastNameInput.Text;
                DateTime birthDate = DateTime.Parse(birthDateInput.Text);
                float gpa = float.Parse(gpaComboBox.Text);

                if (gpa < 0.0f || gpa > 4.0f)
                {
                    MessageBox.Show("GPA must be between 0.0 and 4.0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                    GPA = gpa
                };

                students.Add(newStudent);
                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erroia: {ex.Message}", "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Take Student For Update.", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                var selectedStudent = students[selectedIndex];

                selectedStudent.FirstName = firstNameInput.Text;
                selectedStudent.LastName = lastNameInput.Text;
                selectedStudent.BirthDate = DateTime.Parse(birthDateInput.Text);
                selectedStudent.GPA = float.Parse(gpaComboBox.Text);

                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Take student for Deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int studentId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                var studentToRemove = students.FirstOrDefault(s => s.ID == studentId);
                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                }

                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < students.Count)
            {
                var selectedStudent = students[e.RowIndex];

                IdInput.Text = selectedStudent.ID.ToString();
                firstNameInput.Text = selectedStudent.FirstName;
                lastNameInput.Text = selectedStudent.LastName;
                birthDateInput.Text = selectedStudent.BirthDate.ToShortDateString();
                gpaComboBox.Text = selectedStudent.GPA.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void gpaComboBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            try
            {
                float selectedGPA = float.Parse(gpaComboBox.Text);

                var filteredStudents = students.Where(s => s.GPA >= selectedGPA).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sortByNameButton_Click(object sender, EventArgs e)
        {
            var sortedStudents = students.OrderBy(s => s.FirstName).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sortedStudents;
        }


        private void sortByNameButton_Click_1(object sender, EventArgs e)
        {
            var sortedStudents = students.OrderBy(s => s.FirstName).ToList();

            dataGridView1.DataSource = sortedStudents;
        }

        private void sortByGPA_Click(object sender, EventArgs e)
        {
            var sortedStudents = students.OrderByDescending(s => s.GPA).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sortedStudents;
        }


    }
}