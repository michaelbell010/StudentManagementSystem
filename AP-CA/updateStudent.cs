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
    public partial class updateStudent : Form
    {
        SqlConnection SqlCon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int StudentId = 0;
        public updateStudent()
        {
            InitializeComponent();
        }

        void FillDataGridView()
        {

            SqlCon.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select  * from [Students] where Name like '" + txtSearch.Text+"%'", SqlCon);
            sqlData.SelectCommand.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            dgvStudent.DataSource = dtbl;
            SqlCon.Close();


        }

        private void TxtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Txtpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured!");
            }
        }

        private void DgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index != -1)
            {


                txtName.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();
                txtSname.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                txtCourse.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
                txtAddress.Text = dgvStudent.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();
                txtPhone.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();
                txtCity.Text = dgvStudent.CurrentRow.Cells[7].Value.ToString();
                txtCounty.Text = dgvStudent.CurrentRow.Cells[8].Value.ToString();
                txtStudentID.Text = dgvStudent.CurrentRow.Cells[9].Value.ToString(); 
                StudentId = Convert.ToInt32(dgvStudent.CurrentRow.Cells[10].Value.ToString());

                txtStudentID.ReadOnly = true;
                txtName.ReadOnly = true;
                txtSname.ReadOnly = true;
                txtCourse.ReadOnly = true;
               
            }
        }

        private void BtnupdateStudent_Click(object sender, EventArgs e)
        {
            try
            {

                if (SqlCon.State == ConnectionState.Closed)
                SqlCon.Open();
                dgvStudent.Columns["Name"].ReadOnly = true;
                SqlCommand sqlCmd = new SqlCommand("UPDATE [Students] set Name='" + txtName.Text + "',Sname='" + txtSname.Text + "',Level='" + undGrad.Text + "',Course='" + txtCourse.Text + "',Address='" + txtAddress.Text + "',Email='" + txtEmail.Text + "',Phone='" + txtPhone.Text + "',City='" + txtCity.Text + "',County='" + txtCounty.Text + "',StudentNumber='" + txtStudentID.Text + "'WHERE StudentID='" + StudentId + "'", SqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated");

          

                SqlCon.Close();
                FillDataGridView();


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Invalid Input");
            }

            finally
            {
                SqlCon.Close();
            }

        }

       

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (SqlCon.State == ConnectionState.Closed)
            SqlCon.Open();
            SqlCommand sqlCmd = SqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE from Students where Name='" + this.txtName.Text + "' ;";
            sqlCmd.ExecuteNonQuery();
            SqlCon.Close();
            FillDataGridView();
            MessageBox.Show("Student Record has been deleted");
            
            
        }

        private void DgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform homeForm = new Homeform();
            homeForm.Show();
        }
    }
}


