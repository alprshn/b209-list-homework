﻿namespace b209_list_homework_alper_sahin
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
            dataGridList.BackgroundColor = Color.White;
            dataGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridList.GridColor = Color.FromArgb(109, 122, 224);
            dataGridList.Location = new Point(35, 71);
            dataGridList.Name = "dataGridList";
            dataGridList.RowTemplate.Height = 25;
            dataGridList.Size = new Size(804, 296);
            dataGridList.TabIndex = 0;
            dataGridList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(760, 21);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(188, 23);
            searchBar.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.FlatAppearance.BorderColor = Color.Blue;
            searchButton.FlatAppearance.BorderSize = 2;
            searchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            searchButton.FlatAppearance.MouseOverBackColor = Color.Navy;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(954, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(93, 39);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 562);
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