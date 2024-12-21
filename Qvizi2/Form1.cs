namespace HomeworkOn6dotnet
{
    public partial class Form1 : Form
    {
        private StudentService studentService = new StudentService();


        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshStudentGrid()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentService.GetAllStudents();
        }



        private void sortByAgeButton_Click(object sender, EventArgs e)
        {
            var sortedStudents = studentService.GetAllStudents()
                                                .OrderBy(s => s.Age)
                                                .ToList();

            dataGridView1.DataSource = sortedStudents;
        }

        private void addStudentButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                string name = firstNameInput.Text;
                int age = int.Parse(ageInput.Text);



                var studentCommand = new StudentCommand
                {
                    Name = name,
                    Age = age
                };

                studentCommand.Validate();

                studentService.AddStudent(studentCommand);

                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStudentButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a student for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = int.Parse(IdInput.Text);
                var selectedStudent = studentService.GetAllStudents().Where((n) => n.Id == selectedIndex);


                string updatedName = firstNameInput.Text;
                int updatedAge = int.Parse(ageInput.Text);


                var updatedStudent = new Student(updatedName, updatedAge);


                studentService.UpdateStudent(selectedIndex, updatedStudent);

                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
        

            try
            {
                int studentId = int.Parse(IdInput.Text);

                studentService.DeleteStudent(studentId);

                RefreshStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortByNameButton_Click_1(object sender, EventArgs e)
        {
            var sortedStudents = studentService.GetAllStudents()
                                              .OrderBy(s => s.Name)
                                              .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sortedStudents;
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            var studentToFilter = studentService.GetAllStudents();

            var filteredFileList = studentToFilter.Where(student => student.Name.Contains(textBox1.Text, StringComparison.OrdinalIgnoreCase)).ToList();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredFileList;
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void IdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
