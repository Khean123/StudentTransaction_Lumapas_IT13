using System;
using System.Windows.Forms;

namespace StudentTransaction_Lumapas_IT13
{
    partial class Form1
    {
     
        private System.ComponentModel.IContainer components = null;

        // Tab Control
        private TabControl tabControl1;
        private TabPage tabPageStudents;
        private TabPage tabPageGrades;

        // Student Controls
        private TextBox txtStudentNumber;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCourse;
        private TextBox txtYearLevel;
        private TextBox txtSearchStudent;
        private DataGridView dataGridViewStudents;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private Button btnClearStudent;
        private Button btnSearchStudent;

        // Grade Controls
        private TextBox txtSubject;
        private TextBox txtGrade;
        private TextBox txtSearchGrade;
        private DataGridView dataGridViewGrades;
        private Button btnAddGrade;
        private Button btnDeleteGrade;
        private Button btnClearGrade;
        private Button btnSearchGrade;

        private Label lblTitleStudent;
        private Label lblTitleGrade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtYearLevel = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblTitleStudent = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.tabPageGrades = new System.Windows.Forms.TabPage();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.btnSearchGrade = new System.Windows.Forms.Button();
            this.txtSearchGrade = new System.Windows.Forms.TextBox();
            this.btnClearGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblTitleGrade = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblSearchGrade = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStudents);
            this.tabControl1.Controls.Add(this.tabPageGrades);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 550);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageStudents.BackgroundImage")));
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Controls.Add(this.btnSearchStudent);
            this.tabPageStudents.Controls.Add(this.txtSearchStudent);
            this.tabPageStudents.Controls.Add(this.btnClearStudent);
            this.tabPageStudents.Controls.Add(this.btnDeleteStudent);
            this.tabPageStudents.Controls.Add(this.btnUpdateStudent);
            this.tabPageStudents.Controls.Add(this.btnAddStudent);
            this.tabPageStudents.Controls.Add(this.txtYearLevel);
            this.tabPageStudents.Controls.Add(this.txtCourse);
            this.tabPageStudents.Controls.Add(this.txtLastName);
            this.tabPageStudents.Controls.Add(this.txtFirstName);
            this.tabPageStudents.Controls.Add(this.txtStudentNumber);
            this.tabPageStudents.Controls.Add(this.lblTitleStudent);
            this.tabPageStudents.Controls.Add(this.lblStudentNumber);
            this.tabPageStudents.Controls.Add(this.lblFirstName);
            this.tabPageStudents.Controls.Add(this.lblLastName);
            this.tabPageStudents.Controls.Add(this.lblCourse);
            this.tabPageStudents.Controls.Add(this.lblYearLevel);
            this.tabPageStudents.Controls.Add(this.lblSearchStudent);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(862, 521);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Student Registration";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(403, 103);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(413, 344);
            this.dataGridViewStudents.TabIndex = 12;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(670, 55);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 30);
            this.btnSearchStudent.TabIndex = 11;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(460, 60);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(200, 22);
            this.txtSearchStudent.TabIndex = 10;
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Location = new System.Drawing.Point(305, 220);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(75, 30);
            this.btnClearStudent.TabIndex = 9;
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.UseVisualStyleBackColor = true;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Location = new System.Drawing.Point(220, 220);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(135, 220);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateStudent.TabIndex = 7;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddStudent.Location = new System.Drawing.Point(50, 220);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 30);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtYearLevel
            // 
            this.txtYearLevel.Location = new System.Drawing.Point(180, 180);
            this.txtYearLevel.Name = "txtYearLevel";
            this.txtYearLevel.Size = new System.Drawing.Size(200, 22);
            this.txtYearLevel.TabIndex = 5;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(180, 150);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 22);
            this.txtCourse.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(180, 120);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(180, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(180, 60);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(200, 22);
            this.txtStudentNumber.TabIndex = 1;
            // 
            // lblTitleStudent
            // 
            this.lblTitleStudent.AutoSize = true;
            this.lblTitleStudent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleStudent.Location = new System.Drawing.Point(300, 20);
            this.lblTitleStudent.Name = "lblTitleStudent";
            this.lblTitleStudent.Size = new System.Drawing.Size(312, 29);
            this.lblTitleStudent.TabIndex = 0;
            this.lblTitleStudent.Text = "STUDENT REGISTRATION";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(29, 60);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(141, 20);
            this.lblStudentNumber.TabIndex = 13;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(66, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 20);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(66, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 20);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblCourse
            // 
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(93, 150);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(120, 20);
            this.lblCourse.TabIndex = 16;
            this.lblCourse.Text = "Course:";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.Location = new System.Drawing.Point(66, 180);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(120, 20);
            this.lblYearLevel.TabIndex = 17;
            this.lblYearLevel.Text = "Year Level:";
            // 
            // lblSearchStudent
            // 
            this.lblSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudent.Location = new System.Drawing.Point(400, 60);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(120, 20);
            this.lblSearchStudent.TabIndex = 18;
            this.lblSearchStudent.Text = "Search:";
            // 
            // tabPageGrades
            // 
            this.tabPageGrades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageGrades.BackgroundImage")));
            this.tabPageGrades.Controls.Add(this.dataGridViewGrades);
            this.tabPageGrades.Controls.Add(this.btnSearchGrade);
            this.tabPageGrades.Controls.Add(this.txtSearchGrade);
            this.tabPageGrades.Controls.Add(this.btnClearGrade);
            this.tabPageGrades.Controls.Add(this.btnDeleteGrade);
            this.tabPageGrades.Controls.Add(this.btnAddGrade);
            this.tabPageGrades.Controls.Add(this.txtGrade);
            this.tabPageGrades.Controls.Add(this.txtSubject);
            this.tabPageGrades.Controls.Add(this.lblTitleGrade);
            this.tabPageGrades.Controls.Add(this.lblSubject);
            this.tabPageGrades.Controls.Add(this.lblGrade);
            this.tabPageGrades.Controls.Add(this.lblSearchGrade);
            this.tabPageGrades.Location = new System.Drawing.Point(4, 25);
            this.tabPageGrades.Name = "tabPageGrades";
            this.tabPageGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrades.Size = new System.Drawing.Size(862, 521);
            this.tabPageGrades.TabIndex = 1;
            this.tabPageGrades.Text = "Grade Management";
            this.tabPageGrades.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(400, 100);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersWidth = 51;
            this.dataGridViewGrades.RowTemplate.Height = 24;
            this.dataGridViewGrades.Size = new System.Drawing.Size(450, 400);
            this.dataGridViewGrades.TabIndex = 8;
            this.dataGridViewGrades.SelectionChanged += new System.EventHandler(this.dataGridViewGrades_SelectionChanged);
            // 
            // btnSearchGrade
            // 
            this.btnSearchGrade.Location = new System.Drawing.Point(670, 55);
            this.btnSearchGrade.Name = "btnSearchGrade";
            this.btnSearchGrade.Size = new System.Drawing.Size(75, 30);
            this.btnSearchGrade.TabIndex = 7;
            this.btnSearchGrade.Text = "Search";
            this.btnSearchGrade.UseVisualStyleBackColor = true;
            this.btnSearchGrade.Click += new System.EventHandler(this.btnSearchGrade_Click);
            // 
            // txtSearchGrade
            // 
            this.txtSearchGrade.Location = new System.Drawing.Point(460, 60);
            this.txtSearchGrade.Name = "txtSearchGrade";
            this.txtSearchGrade.Size = new System.Drawing.Size(200, 22);
            this.txtSearchGrade.TabIndex = 6;
            // 
            // btnClearGrade
            // 
            this.btnClearGrade.Location = new System.Drawing.Point(220, 130);
            this.btnClearGrade.Name = "btnClearGrade";
            this.btnClearGrade.Size = new System.Drawing.Size(75, 30);
            this.btnClearGrade.TabIndex = 5;
            this.btnClearGrade.Text = "Clear";
            this.btnClearGrade.UseVisualStyleBackColor = true;
            this.btnClearGrade.Click += new System.EventHandler(this.btnClearGrade_Click);
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.BackColor = System.Drawing.Color.Red;
            this.btnDeleteGrade.Location = new System.Drawing.Point(135, 130);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteGrade.TabIndex = 4;
            this.btnDeleteGrade.Text = "Delete Grade";
            this.btnDeleteGrade.UseVisualStyleBackColor = false;
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddGrade.ForeColor = System.Drawing.Color.Black;
            this.btnAddGrade.Location = new System.Drawing.Point(50, 130);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 30);
            this.btnAddGrade.TabIndex = 3;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(180, 90);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(200, 22);
            this.txtGrade.TabIndex = 2;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(180, 60);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // lblTitleGrade
            // 
            this.lblTitleGrade.AutoSize = true;
            this.lblTitleGrade.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleGrade.Location = new System.Drawing.Point(300, 20);
            this.lblTitleGrade.Name = "lblTitleGrade";
            this.lblTitleGrade.Size = new System.Drawing.Size(282, 29);
            this.lblTitleGrade.TabIndex = 0;
            this.lblTitleGrade.Text = "GRADE MANAGEMENT";
            // 
            // lblSubject
            // 
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(50, 60);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(120, 20);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = "Subject:";
            // 
            // lblGrade
            // 
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(59, 90);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(120, 20);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "Grade:";
            // 
            // lblSearchGrade
            // 
            this.lblSearchGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGrade.Location = new System.Drawing.Point(400, 60);
            this.lblSearchGrade.Name = "lblSearchGrade";
            this.lblSearchGrade.Size = new System.Drawing.Size(120, 20);
            this.lblSearchGrade.TabIndex = 11;
            this.lblSearchGrade.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Student Transaction System - Lumapas";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageGrades.ResumeLayout(false);
            this.tabPageGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lblStudentNumber;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblCourse;
        private Label lblYearLevel;
        private Label lblSearchStudent;
        private Label lblSubject;
        private Label lblGrade;
        private Label lblSearchGrade;
    }
}