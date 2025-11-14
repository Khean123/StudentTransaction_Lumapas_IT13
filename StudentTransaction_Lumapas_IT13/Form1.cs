using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentTransaction_Lumapas_IT13
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DB_Student_Lumapas_IT13;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            ConnectToDatabase();
            LoadStudents();
            LoadGrades();
        }

        private void ConnectToDatabase()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        // ==================== TRANSACTION 1: STUDENT REGISTRATION ====================
        private void LoadStudents()
        {
            try
            {
                string query = "SELECT * FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                try
                {
                    string query = "INSERT INTO Students (StudentNumber, FirstName, LastName, Course, YearLevel) VALUES (@Number, @FirstName, @LastName, @Course, @YearLevel)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Number", txtStudentNumber.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully!");
                    ClearStudentForm();
                    LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding student: " + ex.Message);
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null && ValidateStudentInput())
            {
                try
                {
                    int studentID = Convert.ToInt32(dataGridViewStudents.CurrentRow.Cells["StudentID"].Value);

                    string query = "UPDATE Students SET StudentNumber=@Number, FirstName=@FirstName, LastName=@LastName, Course=@Course, YearLevel=@YearLevel WHERE StudentID=@ID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ID", studentID);
                    cmd.Parameters.AddWithValue("@Number", txtStudentNumber.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully!");
                    ClearStudentForm();
                    LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Delete this student?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int studentID = Convert.ToInt32(dataGridViewStudents.CurrentRow.Cells["StudentID"].Value);

                        // First delete related grades
                        string deleteGradesQuery = "DELETE FROM Grades WHERE StudentID = @StudentID";
                        SqlCommand deleteGradesCmd = new SqlCommand(deleteGradesQuery, connection);
                        deleteGradesCmd.Parameters.AddWithValue("@StudentID", studentID);
                        deleteGradesCmd.ExecuteNonQuery();

                        // Then delete student
                        string query = "DELETE FROM Students WHERE StudentID=@ID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ID", studentID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student deleted successfully!");
                        ClearStudentForm();
                        LoadStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        // FIXED METHOD NAME - Remove the extra space
        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearStudentForm();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string search = txtSearchStudent.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                try
                {
                    string query = "SELECT * FROM Students WHERE StudentNumber LIKE @Search OR FirstName LIKE @Search OR LastName LIKE @Search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + search + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewStudents.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching: " + ex.Message);
                }
            }
            else
            {
                LoadStudents();
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewStudents.CurrentRow;
                txtStudentNumber.Text = row.Cells["StudentNumber"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();
                txtYearLevel.Text = row.Cells["YearLevel"].Value.ToString();
            }
        }

        private bool ValidateStudentInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text) ||
                string.IsNullOrWhiteSpace(txtYearLevel.Text))
            {
                MessageBox.Show("Please fill all student fields");
                return false;
            }

            if (!int.TryParse(txtYearLevel.Text, out int yearLevel) || yearLevel < 1 || yearLevel > 5)
            {
                MessageBox.Show("Please enter valid year level (1-5)");
                return false;
            }

            return true;
        }

        private void ClearStudentForm()
        {
            txtStudentNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            txtSearchStudent.Clear();
            dataGridViewStudents.ClearSelection();
        }

        // ==================== TRANSACTION 2: GRADE MANAGEMENT ====================
        private void LoadGrades()
        {
            try
            {
                string query = @"SELECT g.GradeID, s.StudentNumber, s.FirstName, s.LastName, g.Subject, g.Grade 
                               FROM Grades g 
                               INNER JOIN Students s ON g.StudentID = s.StudentID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewGrades.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (ValidateGradeInput())
            {
                try
                {
                    int selectedStudentID = GetSelectedStudentID();
                    if (selectedStudentID != -1)
                    {
                        string query = "INSERT INTO Grades (StudentID, Subject, Grade) VALUES (@StudentID, @Subject, @Grade)";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);
                        cmd.Parameters.AddWithValue("@Subject", txtSubject.Text);
                        cmd.Parameters.AddWithValue("@Grade", decimal.Parse(txtGrade.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Grade added successfully!");
                        ClearGradeForm();
                        LoadGrades();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding grade: " + ex.Message);
                }
            }
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Delete this grade?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int gradeID = Convert.ToInt32(dataGridViewGrades.CurrentRow.Cells["GradeID"].Value);
                        string query = "DELETE FROM Grades WHERE GradeID=@ID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ID", gradeID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Grade deleted successfully!");
                        ClearGradeForm();
                        LoadGrades();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting grade: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a grade to delete.");
            }
        }

        // FIXED METHOD NAME - Remove the extra space
        private void btnClearGrade_Click(object sender, EventArgs e)
        {
            ClearGradeForm();
        }

        private void btnSearchGrade_Click(object sender, EventArgs e)
        {
            string search = txtSearchGrade.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                try
                {
                    string query = @"SELECT g.GradeID, s.StudentNumber, s.FirstName, s.LastName, g.Subject, g.Grade 
                                   FROM Grades g 
                                   INNER JOIN Students s ON g.StudentID = s.StudentID
                                   WHERE s.StudentNumber LIKE @Search OR s.FirstName LIKE @Search OR s.LastName LIKE @Search OR g.Subject LIKE @Search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + search + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewGrades.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching grades: " + ex.Message);
                }
            }
            else
            {
                LoadGrades();
            }
        }

        private void dataGridViewGrades_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewGrades.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewGrades.CurrentRow;
                txtSubject.Text = row.Cells["Subject"].Value.ToString();
                txtGrade.Text = row.Cells["Grade"].Value.ToString();
            }
        }

        private int GetSelectedStudentID()
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                return Convert.ToInt32(dataGridViewStudents.CurrentRow.Cells["StudentID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a student first from the Student Registration tab");
                return -1;
            }
        }

        private bool ValidateGradeInput()
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) ||
                string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill all grade fields");
                return false;
            }

            if (!decimal.TryParse(txtGrade.Text, out decimal grade) || grade < 1.0m || grade > 5.0m)
            {
                MessageBox.Show("Please enter valid grade (1.0 - 5.0)");
                return false;
            }

            return true;
        }

        private void ClearGradeForm()
        {
            txtSubject.Clear();
            txtGrade.Clear();
            txtSearchGrade.Clear();
            dataGridViewGrades.ClearSelection();
        }

        private void tabPageGrades_Click(object sender, EventArgs e)
        {
            // This method can be empty or used for refresh if needed
        }

        // Add this method to refresh grades when switching to grades tab
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageGrades)
            {
                LoadGrades();
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}