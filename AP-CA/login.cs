using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_CA
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection String   
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT UserID FROM [dbo].[logins] WHERE LoginName=@pLoginName AND PasswordHash=HASHBYTES('SHA2_512', @pPassword+CAST(Salt AS NVARCHAR(73)))", con);
            cmd.Parameters.AddWithValue("@pLoginName", textBox1.Text);
            cmd.Parameters.AddWithValue("@pPassword", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           // Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                
                MessageBox.Show("Successfully logged in");
                this.Hide();
                Homeform homeForm = new Homeform();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //AdministratorLogin al = new AdministratorLogin();
            //al.Show();
            //this.Hide();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CloseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
