using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Town_Country.GUI
{
    public partial class Login : Form
    {
        public static string ID;
        public static string name;


        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }


        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb");
            OleDbCommand command = new OleDbCommand($"Select * from Userprofile where [UserName] = '{txtusername.Text}' and [Password] = '{txtpassword.Text}'", con);
            OleDbDataAdapter ad = new OleDbDataAdapter(command);
            con.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                name = reader[2].ToString(); 
                ID = reader[0].ToString();

                // Form1 f1 = new Form1();

                this.Hide();
                Form1 f1 = new Form1();
                f1.Closed += (s, args) => this.Close();
                f1.Show();


                //f1.Show();

            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
            con.Close();

           

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register sign= new Register();
            sign.ShowDialog();
            
        }
    }
}
