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
    public partial class frmdeals : Form
    {
        public frmdeals()
        {
            InitializeComponent();
        }

        private void frmdeals_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb";

            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand command = new OleDbCommand("Select * from Payment", con);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            con.Open();

            da.Fill(dt);

            con.Close();
        }

        private void btndeals_Click(object sender, EventArgs e)
        {
            if (Login.ID != null)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=User profile.accdb";
                OleDbConnection con = new OleDbConnection(connectionString);

                string UserName = txtUsername.Text;
                string Job = txtJob.Text;
                string NoPhone = txtNophone.Text;
                string Paymentmethod = cmbPay.Text;
                string Nationality = cmbNationality.Text;

                string insertCommand = $"Insert Into Payment ([UserName],[Job],[NoPhone],[Paymentmethod],[Nationality]) " +
                    $"values('{UserName}','{Job}','{NoPhone}','{Paymentmethod}','{Nationality}')";

                OleDbCommand command = new OleDbCommand(insertCommand, con);
                con.Open();

                command.ExecuteNonQuery();

                con.Close();

                this.Close();

            }
            else
            {
                
                MessageBox.Show("You must Login first ");
            }
                

            
        }
    }
}
