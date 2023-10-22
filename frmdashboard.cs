using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Program_Adder
{
    public partial class frmdashboard : Form
    {
        string installdir;

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

        public frmdashboard()
        {
            InitializeComponent();

            btnopen_site.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnopen_site.Width, btnopen_site.Height, 20, 20));
            commit_changes_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, commit_changes_btn.Width, commit_changes_btn.Height, 20, 20));
            btnopen_lab.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnopen_lab.Width, btnopen_lab.Height, 20, 20));
        }

        private void btnopen_site_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

                installdir = regkey.GetValue("installdir").ToString();
                Process.Start("chrome.exe",$"\"{installdir}\\index.html\"");
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
            }          
        }

        private void commit_changes_btn_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {          
                try
                {
                    regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

                    installdir = regkey.GetValue("installdir").ToString();

                    //git commands starts --sending commands via command line
                    string cd = $@"/C cd /d {installdir}";
                    string add = $"& git add .";
                    string commit = $"& git commit -m \"From APP on {DateTime.Now}\"";
                    string push = $"& git push";
                    Process process66811 = new Process();
                    ProcessStartInfo startInfo66811 = new ProcessStartInfo();
                    startInfo66811.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo66811.FileName = "cmd.exe";
                    startInfo66811.Arguments = cd + add + commit + push;
                    process66811.StartInfo = startInfo66811;
                    process66811.Start();
                    //finished git commands

                    MessageBox.Show("Changes Commited Sucessfully.","SUCCESS !!");
                }
                catch(Exception ex)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
            }
        }

        private void btnopen_lab_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

                installdir = regkey.GetValue("installdir").ToString();

                Process.Start("subl", $"\"{installdir}\\Lab.html\"");
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Application Not Installed.\n\nInstall the Application First.", "ERROR !!");
            }
        }
    }
}
