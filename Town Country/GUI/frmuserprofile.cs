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
using System.Xml.Linq;

namespace Town_Country.GUI
{
    public partial class frmuserprofile : Form
    {
        public frmuserprofile()
        {
            InitializeComponent();
        }

        private void frmuserprofile_Load(object sender, EventArgs e)
        {
            if(Login.ID!=null) { 
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb");
            OleDbCommand command1 = new OleDbCommand($"Select * from Userprofile where [ID] = {Login.ID}", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command1);
            con.Open();
            OleDbDataReader reader = command1.ExecuteReader();
            if (reader.Read() == true)
            {
                txtname.Text = reader[1].ToString();
                txtusername.Text = reader[2].ToString();
                txtemail.Text = reader[3].ToString();
                 

            }

            con.Close();
            }
        }

        private void pibxuserprofile_Click(object sender, EventArgs e)
        {

        }
    }
}
