using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_CA
{
    public partial class st_registration_form : login
    {
        public st_registration_form()
        {
            InitializeComponent();
        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void St_registration_form_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            {
               
                SqlConnection SqlCon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                try
                {


                    if (SqlCon.State == ConnectionState.Closed)
                        SqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddStudent", SqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;



                    sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Sname", txtSname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Level", undGrad.Checked ? "Undergraduate" : "Postgraduate");
                    sqlCmd.Parameters.AddWithValue("@Course", txtCourse.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@County", txtCounty.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", txtStudentID.Text.Trim());


                    TextBox[] newTextBox = { txtAddress, txtCity, txtEmail, txtPhone, txtName, txtSname };
                    for (int inti = 0; inti < newTextBox.Length; inti ++)
                    {
                        if (newTextBox[inti].Text == string.Empty)
                        {
                            MessageBox.Show("Please fill the text box");
                            newTextBox[inti].Focus();
                            return;
                        }
                    }

                    if (txtStudentID.Text.Length == 8)
                    {
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Student Added");

                     
                    }
                    else
                    {
                        MessageBox.Show("Student ID has to be 8 Digits");
                    }
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
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 8)
            {
                label1.Text = "Student ID has to be 8 Digits";
            }
        }
        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homeform homeForm = new Homeform();
            homeForm.Show();
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
