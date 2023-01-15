using Microsoft.VisualBasic.Logging;
using Town_Country.GUI;

namespace Town_Country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //string message = "Are you sure you went to exit this application?";
            // string title = "Exit Application";
            //MessageBoxButtons button = MessageBoxButtons.YesNo;
            // DialogResult result =  MessageBox.Show(message,title,button);
            //if (result == DialogResult.Yes)
            // Application.Exit();
            if (Login.ID != null) { 

                lbluser.Text = "user";
            Login.name = null;
                Login.ID = null;


            }

        }

        private void buttonuserprofile_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmuserprofile profile = new frmuserprofile() { TopLevel = false, TopMost = true };
            profile.FormBorderStyle= FormBorderStyle.None;
            panelContent.Controls.Add(profile);
            profile.Show();
            
          
        }

        private void btnrealestate_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();  
            frmRealEstates realEstates= new frmRealEstates() { TopLevel=false, TopMost=true };
            realEstates.FormBorderStyle= FormBorderStyle.None;
            panelContent.Controls.Add(realEstates);
            realEstates.Show();
        }

        private void buttondeals_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            frmdeals deals = new frmdeals() { TopLevel=false,TopMost=true };
            deals.FormBorderStyle= FormBorderStyle.None;
            panelContent.Controls.Add(deals);
            deals.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Register signup = new Register();
            
            signup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Login.name != null )
            {
                lbluser.Text = Login.name;
            }
            else
            {
                lbluser = null;
            }

        }

       
    }
}