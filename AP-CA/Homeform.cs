using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AP_CA
{
    public partial class Homeform : Form
    {
        private string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog = StudentManagement; Integrated Security = True;";

        public Homeform()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void disp_data()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM [Students]", sqlConnection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dgv.DataSource = dtbl;


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM [Students]", sqlConnection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                dgv.DataSource = dtbl;


            }


        }

        public void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            st_registration_form stregform = new st_registration_form();
            stregform.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            st_registration_form stregform = new st_registration_form();
            stregform.FormClosed += (s, args) => this.Close();
            stregform.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateStudent updateStudent = new updateStudent();
            updateStudent.FormClosed += (s, args) => this.Close();
            updateStudent.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            updateStudent updateStudent = new updateStudent();
            updateStudent.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Homeform_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
