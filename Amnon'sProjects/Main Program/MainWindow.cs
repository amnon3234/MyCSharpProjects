using System;
using System.Drawing;
using System.Windows.Forms;

namespace Amnon_sProjects.Main_Program
{
    public partial class MainWindow : Form
    {
        //Data
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        public MainWindow()
        {
            InitializeComponent();
            this.homeFrame1.BringToFront();
        }
        
            
            
        // --------------------------------------------------- Mouse click Event ----------------------------------------------
       
        private void Contacts_Click(object sender, EventArgs e)
        {
            var curr = sender is PictureBox ? (PictureBox) sender : null;
            if (curr == null) return;
            switch (curr.Name)
            {
                case "facebook":
                    System.Diagnostics.Process.Start("https://www.facebook.com/amnon1233/");
                    break;
                case "instagram":
                    System.Diagnostics.Process.Start("https://www.instagram.com/amnonashkenazy/");
                    break;
                case "gitHub":
                    System.Diagnostics.Process.Start("https://github.com/amnon3234");
                    break;
                case "linkedin":
                    System.Diagnostics.Process.Start("https://www.linkedin.com/in/amnon-ashkenazy-a1590b181/");
                    break;
                default:
                    System.Diagnostics.Process.Start("mailto:amnon3234@gmail.com");
                    break;
            }
        }

        private void shutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button curr = sender is Button ? (Button) sender : null;
            if (curr == null) return;
            sidePanel.Top = curr.Top;
            switch (curr.Name)
            {
                case "toHomeFrame":
                    this.homeFrame1.BringToFront();
                    break;
                case "toSudoku":
                    this.sudokuFrame1.BringToFront();
                    break;
                case "toShortestPath":
                    this.LightestPathFrame1.BringToFront();
                    break;
            }
        }

        // --------------------------------------------------- Mouse Enter Effect ---------------------------------------------

        private void Contacts_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(35, 34);
        }

        private void Contacts_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Size = new Size(30, 29);
        }

        // ------------------------------------------ Make the border less form movable ----------------------------------------

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
          
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }
    }
}
