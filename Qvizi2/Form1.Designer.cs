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
            ageInput = new TextBox();
            IdInput = new TextBox();
            dataGridView1 = new DataGridView();
            addStudentButton = new Button();
            updateStudentButton = new Button();
            DeleteButton = new Button();
            SortByNameButton = new Button();
            sortByAgeButton = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(97, 155);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(100, 23);
            firstNameInput.TabIndex = 1;
            firstNameInput.TextChanged += firstNameInput_TextChanged;
            // 
            // birthDateInput
            // 
            ageInput.Location = new Point(97, 222);
            ageInput.Name = "birthDateInput";
            ageInput.Size = new Size(100, 23);
            ageInput.TabIndex = 3;
            // 
            // IdInput
            // 
            IdInput.Location = new Point(289, 444);
            IdInput.Name = "IdInput";
            IdInput.Size = new Size(100, 23);
            IdInput.TabIndex = 6;
            IdInput.TextChanged += IdInput_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(372, 297);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(100, 88);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(97, 23);
            addStudentButton.TabIndex = 7;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click_1;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(140, 443);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(132, 23);
            updateStudentButton.TabIndex = 8;
            updateStudentButton.Text = "Update Student";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updateStudentButton_Click_1;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(404, 444);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SortByNameButton
            // 
            SortByNameButton.Location = new Point(719, 133);
            SortByNameButton.Name = "SortByNameButton";
            SortByNameButton.Size = new Size(117, 23);
            SortByNameButton.TabIndex = 10;
            SortByNameButton.Text = "Sort by Name";
            SortByNameButton.UseVisualStyleBackColor = true;
            SortByNameButton.Click += sortByNameButton_Click_1;
            // 
            // sortByAgeButton
            // 
            sortByAgeButton.Location = new Point(719, 245);
            sortByAgeButton.Name = "sortByAgeButton";
            sortByAgeButton.Size = new Size(117, 23);
            sortByAgeButton.TabIndex = 11;
            sortByAgeButton.Text = "Sort+ By Age";
            sortByAgeButton.UseVisualStyleBackColor = true;
            sortByAgeButton.Click += sortByAgeButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 444);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(728, 473);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 137);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 14;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 191);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 14;
            label2.Text = "age";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 419);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 14;
            label3.Text = "ID";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(719, 419);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 15;
            label4.Text = "Filter By Name";
            // 
            // Form1
            // 
            ClientSize = new Size(910, 572);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(sortByAgeButton);
            Controls.Add(SortByNameButton);
            Controls.Add(DeleteButton);
            Controls.Add(updateStudentButton);
            Controls.Add(addStudentButton);
            Controls.Add(IdInput);
            Controls.Add(ageInput);
            Controls.Add(firstNameInput);
            Controls.Add(dataGridView1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameInput;
        private TextBox ageInput;
        private TextBox textBox5;
        private TextBox IdInput;
        private DataGridView dataGridView1;
        private Button addStudentButton;
        private Button updateStudentButton;
        private Button DeleteButton;
        private Button SortByNameButton;
        private Button sortByAgeButton;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
