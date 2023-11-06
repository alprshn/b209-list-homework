namespace b209_list_homework_alper_sahin
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
            dataGridList = new DataGridView();
            searchBar = new TextBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridList).BeginInit();
            SuspendLayout();
            // 
            // dataGridList
            // 
            dataGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridList.Location = new Point(27, 148);
            dataGridList.Name = "dataGridList";
            dataGridList.RowTemplate.Height = 25;
            dataGridList.Size = new Size(1012, 377);
            dataGridList.TabIndex = 0;
            dataGridList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(724, 92);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(188, 23);
            searchBar.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(918, 91);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 562);
            Controls.Add(searchButton);
            Controls.Add(searchBar);
            Controls.Add(dataGridList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridList;
        private TextBox searchBar;
        private Button searchButton;
    }
}