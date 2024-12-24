namespace HomeworkOn6dotnet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            birthDateInput = new TextBox();
            IdInput = new TextBox();
            dataGridView1 = new DataGridView();
            addStudentButton = new Button();
            updateStudentButton = new Button();
            DeleteButton = new Button();
            gpaComboBox = new ComboBox();
            sortByNameButton = new Button();
            sortByGPA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(89, 199);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(100, 23);
            firstNameInput.TabIndex = 1;
            firstNameInput.TextChanged += firstNameInput_TextChanged;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(89, 238);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(100, 23);
            lastNameInput.TabIndex = 2;
            lastNameInput.TextChanged += lastNameInput_TextChanged;
            // 
            // birthDateInput
            // 
            birthDateInput.Location = new Point(89, 278);
            birthDateInput.Name = "birthDateInput";
            birthDateInput.Size = new Size(100, 23);
            birthDateInput.TabIndex = 3;
            birthDateInput.TextChanged += birthDateInput_TextChanged;
            // 
            // IdInput
            // 
            IdInput.Location = new Point(390, 121);
            IdInput.Name = "IdInput";
            IdInput.Size = new Size(100, 23);
            IdInput.TabIndex = 6;
            IdInput.TextChanged += IdInput_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(31, 366);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(97, 23);
            addStudentButton.TabIndex = 7;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(150, 366);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(132, 23);
            updateStudentButton.TabIndex = 8;
            updateStudentButton.Text = "Update Student";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += UpdateStudentButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(511, 121);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // gpaComboBox
            // 
            gpaComboBox.Location = new Point(89, 319);
            gpaComboBox.Name = "gpaComboBox";
            gpaComboBox.Size = new Size(121, 23);
            gpaComboBox.TabIndex = 0;
            gpaComboBox.SelectedIndexChanged += gpaComboBox_SelectedIndexChanged;
            // 
            // sortByNameButton
            // 
            sortByNameButton.Location = new Point(628, 120);
            sortByNameButton.Name = "sortByNameButton";
            sortByNameButton.Size = new Size(117, 23);
            sortByNameButton.TabIndex = 10;
            sortByNameButton.Text = "Filter by Name";
            sortByNameButton.UseVisualStyleBackColor = true;
            sortByNameButton.Click += sortByNameButton_Click_1;
            // 
            // sortByGPA
            // 
            sortByGPA.Location = new Point(751, 120);
            sortByGPA.Name = "sortByGPA";
            sortByGPA.Size = new Size(114, 23);
            sortByGPA.TabIndex = 11;
            sortByGPA.Text = "Filter By GPA";
            sortByGPA.UseVisualStyleBackColor = true;
            sortByGPA.Click += sortByGPA_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(910, 572);
            Controls.Add(sortByGPA);
            Controls.Add(sortByNameButton);
            Controls.Add(gpaComboBox);
            Controls.Add(DeleteButton);
            Controls.Add(updateStudentButton);
            Controls.Add(addStudentButton);
            Controls.Add(IdInput);
            Controls.Add(birthDateInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(dataGridView1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox birthDateInput;
        private TextBox textBox5;
        private TextBox IdInput;
        private DataGridView dataGridView1;
        private Button addStudentButton;
        private Button updateStudentButton;
        private Button DeleteButton;
        private ComboBox gpaComboBox;
        private Button sortByNameButton;
        private Button sortByGPA;
    }
}
