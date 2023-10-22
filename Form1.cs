using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Program_Adder
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------------
        //moving the form
        private bool mouseDown;
        private Point lastLocation;
        //-------------------------------------------------------

        //registry Operations
        static readonly RegistryKey BaseFolderPath = Registry.CurrentUser;
        static readonly string subkey = @"Arun Shrestha\Code Storage\DSA";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlNav.Height = btndashboard.Height;
            pnlNav.Top = btndashboard.Top;
            pnlNav.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmdashboard Frmdashboard_Vrb = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            btnadd.BackColor = Color.FromArgb(24, 30, 54);
            btndelete.BackColor = Color.FromArgb(24, 30, 54);
            btninstall.BackColor = Color.FromArgb(24, 30, 54);
            btnedit.BackColor = Color.FromArgb(24, 30, 54);

            pnlNav.Height = btndashboard.Height;
            pnlNav.Top = btndashboard.Top;
            pnlNav.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmdashboard Frmdashboard_Vrb = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
            btndelete.BackColor = Color.FromArgb(24, 30, 54);
            btninstall.BackColor = Color.FromArgb(24, 30, 54);
            btnedit.BackColor = Color.FromArgb(24, 30, 54);

            pnlNav.Height = btnadd.Height;
            pnlNav.Top = btnadd.Top;
            pnlNav.Left = btnadd.Left;
            btnadd.BackColor = Color.FromArgb(46, 51, 73);
            
            frmadd Frmdashboard_Vrb;

            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                Title.Text = "Add Program";
                this.PnlFormLoader.Controls.Clear();
                Frmdashboard_Vrb = new frmadd() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(Frmdashboard_Vrb);
                Frmdashboard_Vrb.Show();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
                btninstall.PerformClick();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
            btnadd.BackColor = Color.FromArgb(24, 30, 54);
            btninstall.BackColor = Color.FromArgb(24, 30, 54);
            btnedit.BackColor = Color.FromArgb(24, 30, 54);

            pnlNav.Height = btndelete.Height;
            pnlNav.Top = btndelete.Top;
            pnlNav.Left = btndelete.Left;
            btndelete.BackColor = Color.FromArgb(46, 51, 73);

            frmdelete Frmdashboard_Vrb;

            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                Title.Text = "Delete Program";
                this.PnlFormLoader.Controls.Clear();
                Frmdashboard_Vrb = new frmdelete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(Frmdashboard_Vrb);
                Frmdashboard_Vrb.Show();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
                btninstall.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            string username;
            if (regkey.OpenSubKey(subkey) != null)
            {
                regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

                username = regkey.GetValue("username").ToString();
                lblusername.Text = "Hello " + username;
            }
            else
            {
                lblusername.Text = "Hello User";
            }
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.sthaarun.com.np");
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCp_Ga7MHoabOS9qPEia9keQ");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/arun457");
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
            btndelete.BackColor = Color.FromArgb(24, 30, 54);
            btnadd.BackColor = Color.FromArgb(24, 30, 54);
            btnedit.BackColor = Color.FromArgb(24, 30, 54);

            pnlNav.Height = btninstall.Height;
            pnlNav.Top = btninstall.Top;
            pnlNav.Left = btninstall.Left;
            btninstall.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Install Program";
            this.PnlFormLoader.Controls.Clear();
            frminstall Frmdashboard_Vrb = new frminstall() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Frmdashboard_Vrb);
            Frmdashboard_Vrb.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            //setting the colour of other tabs to deep blue
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
            btndelete.BackColor = Color.FromArgb(24, 30, 54);
            btninstall.BackColor = Color.FromArgb(24, 30, 54);
            btnadd.BackColor = Color.FromArgb(24, 30, 54);

            pnlNav.Height = btnedit.Height;
            pnlNav.Top = btnedit.Top;
            pnlNav.Left = btnedit.Left;
            btnedit.BackColor = Color.FromArgb(46, 51, 73);
            
            frmedit Frmedit_Vrb;
            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                Title.Text = "Edit Program";
                this.PnlFormLoader.Controls.Clear();
                Frmedit_Vrb = new frmedit() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                Frmedit_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(Frmedit_Vrb);
                Frmedit_Vrb.Show();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
                btninstall.PerformClick();
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
