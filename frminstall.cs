using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Program_Adder
{
    public partial class frminstall : Form
    {
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

        public frminstall()
        {
            InitializeComponent();

            //creating round borders
            Installbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Installbtn.Width, Installbtn.Height, 20, 20));
            installdirip.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, installdirip.Width, installdirip.Height, 10, 10));
            name.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, name.Width, name.Height, 10, 10));
            default_file.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, default_file.Width, default_file.Height, 10, 10));
        }

        private void Installbtn_Click(object sender, EventArgs e)
        {
            //Performing Checks
            if (string.IsNullOrEmpty(installdirip.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Installation Directory Cannot be Empty.", "ERROR !!!");
                return;
            }
            if (string.IsNullOrEmpty(name.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Name Cannot be Empty.", "ERROR !!!");
                return;
            }
            if (name.Text.IndexOf(' ') >= 0)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Please Enter First Name Only.", "ERROR !!!");
                return;
            }
            if (!Directory.Exists(installdirip.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Installation Directory Doesn't Exists !!", "Error !!!");
                return;
            }
            if(!string.IsNullOrEmpty(default_file.Text) && !File.Exists(default_file.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Default Working File Doesn't Exists !!", "Error !!!");
                return;
            }
            //Finished Performing checks

            //Actions to perform if all checks are clear.
            string installdir = installdirip.Text;
            string username = name.Text;
            string Default_file;
            if(!String.IsNullOrEmpty(default_file.Text))
            {
                Default_file = default_file.Text;
            }
            else
            {
                Default_file = "not_set";
            }

            RegistryKey regkey = BaseFolderPath;
            if (regkey.OpenSubKey(subkey) != null)
            {
                SystemSounds.Asterisk.Play();
                DialogResult dialogResult = MessageBox.Show($"The Code Storage Application is already installed in your computer.\n\nDo you want to reinstall the Application?", "Warning !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    regkey = regkey.CreateSubKey(subkey); //creating the registry key

                    regkey.SetValue("installdir", installdir);
                    regkey.SetValue("username", username);
                    regkey.SetValue("default_file", Default_file);

                    MessageBox.Show("Application Installed", "SUCCESS !!!");
                    installdirip.Text = "";
                    name.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Operation Cancelled", "Cancelled !!!");
                }
            }
            else
            {
                regkey = regkey.CreateSubKey(subkey); //creating the registry key

                regkey.SetValue("installdir", installdir);
                regkey.SetValue("username", username);
                regkey.SetValue("default_file", Default_file);
                //finished making registry key

                MessageBox.Show("Application Installed", "SUCCESS !!!");
                installdirip.Text = ""; //resetting the apk
                name.Text = "";
            }
        }
    }
}
