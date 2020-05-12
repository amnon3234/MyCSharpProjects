using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amnon_sProjects
{
    public partial class HomeFrame : UserControl
    {
        public HomeFrame()
        {
            InitializeComponent();
        }


        // --------------------------------------------------- Mouse clike Event ----------------------------------------------

        private void hireMe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:amnon3234@gmail.com");
        }

        // --------------------------------------------------- Mouse Enter Effect ---------------------------------------------

        private void Skills_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(70, 70);
        }

        private void Skills_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(60, 60);
        }

    }
}
