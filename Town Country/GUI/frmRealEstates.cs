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
    public partial class frmRealEstates : Form
    {
        public frmRealEstates()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int intImanum = 0; 
        private void tmrrent_Tick(object sender, EventArgs e)
        {
            picbx1.Image = imglsrent.Images[intImanum];
            if (intImanum == imglsrent.Images.Count -1) 
            {
                intImanum = 0;
            }
            else
            {
                intImanum++;
            }


        }

        private void btnShowmore_Click(object sender, EventArgs e)
        {
            frmShowMore fshow = new frmShowMore();
            fshow.ShowDialog();

        }
    }
}
