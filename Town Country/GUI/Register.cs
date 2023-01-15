using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Town_Country.GUI
{
    public partial class Register : Form
    {
        
        public Register()
        {
           
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb";

           OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand command = new OleDbCommand("Select * from UserProfile", con);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb";
            OleDbConnection con = new OleDbConnection(connectionString);

            string Name = txtname.Text;
            string UserName = txtusername.Text;
            string EMAIL = txtemail.Text;
            string Password = txtpassword.Text; 
            string confirmPassword = txtcppass.Text;

            string insertCommand = $"Insert Into Userprofile ([Name],[UserName],[EMAIL],[Password],[confirmPassword]) " +
                $"values('{Name}','{UserName}','{EMAIL}','{Password}','{confirmPassword}')";                           

                OleDbCommand command = new OleDbCommand(insertCommand, con);
            con.Open();

            command.ExecuteNonQuery();

            con.Close();

            this.Hide();
            Form1 f1 = new Form1();
            f1.Closed += (s, args) => this.Close();
            f1.Show();



        }
    }
}
    