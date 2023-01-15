using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Town_Country.GUI
{
    public partial class frmShowMore : Form
    {
        public frmShowMore()
        {
            InitializeComponent();
        }

        private void btnshowmore_Click(object sender, EventArgs e)
        {
            Homeabdoun home = new Homeabdoun();
            home.Show();
        }

        private void btnshowmore1_Click(object sender, EventArgs e)
        {
            HomeTabarbour home2 = new HomeTabarbour();  
            home2.ShowDialog();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            frmdeals payment= new frmdeals();   
            payment.ShowDialog();
        }

        private void btnbuy1_Click(object sender, EventArgs e)
        {
            frmdeals payment = new frmdeals();
            payment.ShowDialog();
        }
    }
}
