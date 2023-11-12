namespace b209_list_homework_alper_sahin
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            studentPhoto = new PictureBox();
            activeStudent = new Label();
            gpaStudent = new Label();
            birthStudent = new Label();
            idStudent = new Label();
            nameStudent = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridTranscript = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTranscript).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(studentPhoto);
            panel1.Controls.Add(activeStudent);
            panel1.Controls.Add(gpaStudent);
            panel1.Controls.Add(birthStudent);
            panel1.Controls.Add(idStudent);
            panel1.Controls.Add(nameStudent);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridTranscript);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(151, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 402);
            panel1.TabIndex = 0;
            // 
            // studentPhoto
            // 
            studentPhoto.Image = Properties.Resources._4;
            studentPhoto.Location = new Point(514, 101);
            studentPhoto.Name = "studentPhoto";
            studentPhoto.Size = new Size(146, 155);
            studentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPhoto.TabIndex = 14;
            studentPhoto.TabStop = false;
            studentPhoto.Click += pictureBox1_Click;
            // 
            // activeStudent
            // 
            activeStudent.AutoSize = true;
            activeStudent.Location = new Point(86, 222);
            activeStudent.Name = "activeStudent";
            activeStudent.Size = new Size(40, 15);
            activeStudent.TabIndex = 13;
            activeStudent.Text = "Active";
            // 
            // gpaStudent
            // 
            gpaStudent.AutoSize = true;
            gpaStudent.Location = new Point(86, 195);
            gpaStudent.Name = "gpaStudent";
            gpaStudent.Size = new Size(29, 15);
            gpaStudent.TabIndex = 12;
            gpaStudent.Text = "GPA";
            // 
            // birthStudent
            // 
            birthStudent.AutoSize = true;
            birthStudent.Location = new Point(86, 171);
            birthStudent.Name = "birthStudent";
            birthStudent.Size = new Size(32, 15);
            birthStudent.TabIndex = 11;
            birthStudent.Text = "Birth";
            // 
            // idStudent
            // 
            idStudent.AutoSize = true;
            idStudent.Location = new Point(86, 143);
            idStudent.Name = "idStudent";
            idStudent.Size = new Size(18, 15);
            idStudent.TabIndex = 10;
            idStudent.Text = "ID";
            // 
            // nameStudent
            // 
            nameStudent.AutoSize = true;
            nameStudent.Location = new Point(86, 113);
            nameStudent.Name = "nameStudent";
            nameStudent.Size = new Size(39, 15);
            nameStudent.TabIndex = 9;
            nameStudent.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 222);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 8;
            label8.Text = "Active";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 195);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 7;
            label7.Text = "GPA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 171);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 6;
            label6.Text = "Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 143);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 5;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 113);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Name";
            // 
            // dataGridTranscript
            // 
            dataGridTranscript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTranscript.Location = new Point(174, 101);
            dataGridTranscript.Name = "dataGridTranscript";
            dataGridTranscript.RowTemplate.Height = 25;
            dataGridTranscript.Size = new Size(318, 155);
            dataGridTranscript.TabIndex = 3;
            dataGridTranscript.CellContentClick += dataGridTranscript_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 56);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Student Photo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Transcript";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "General Info";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 554);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTranscript).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox studentPhoto;
        private Label activeStudent;
        private Label gpaStudent;
        private Label birthStudent;
        private Label idStudent;
        private Label nameStudent;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridTranscript;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}