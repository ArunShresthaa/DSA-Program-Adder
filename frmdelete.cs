using System;
using System.IO;
using System.Media;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Win32;

namespace Program_Adder
{
    public partial class frmdelete : Form
    {
        string installdir;
        int maxfilesize = 100;

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

        public frmdelete()
        {
            InitializeComponent();

            deletebtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deletebtn.Width, deletebtn.Height, 20, 20));
            question.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, question.Width, question.Height, 10, 10));
            chapter_choose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chapter_choose.Width, chapter_choose.Height, 10, 10));
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //Performing checks
            if (string.IsNullOrEmpty(chapter_choose.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Please Choose A Chapter.", "ERROR!!");
                return;
            }
            if (string.IsNullOrEmpty(question.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Question cannot be Empty.", "ERROR!!");
                return;
            }
            //Finished Performing Checks.


            //Actions to Perform if all Checks are clear.
            string filepath = $@"{installdir}\{chapter_choose.Text}.html";
            if (File.Exists(filepath))
            {
                //removing illegal characters in herf filepath.
                string hreffilename = question.Text;
                string invalid = "!@#$%^&*()_+-=[]{}\\|;:'\",<.>/?`~* ";

                foreach (char c in invalid)
                {
                    hreffilename = hreffilename.Replace(c.ToString(), "");
                }
                //finished removing illegal characters.

                hreffilename = new string(hreffilename.Take(maxfilesize).ToArray()); //taking only first 200 letters of question as file name
       
                string hreffp = $@"{installdir}\Programs\{chapter_choose.Text}\{hreffilename}.html"; //making hreffilepath
                if (File.Exists(hreffp))
                {
                    //deleting the question
                    string hreftxt = $@"Programs/{chapter_choose.Text}/{hreffilename}.html";
                    string replacelocation = $"<li><a href=\"{hreftxt}\" target=\"_blank\">{question.Text}</a></li>";
                    string replacetext = "";
                    string filecontent = File.ReadAllText(filepath);
                    string replacedcontent = filecontent.Replace(replacelocation, replacetext);
                    File.WriteAllText(filepath, replacedcontent);
                    //finished deleting the question

                    if (File.Exists(hreffp))
                    {
                        File.Delete(hreffp);
                    }
                    MessageBox.Show("Done", "SUCCESS!!");

                    //Resetting the App
                    question.Text = "";
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show($"The Question Does not Exists.", "ERROR!!");
                }

            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show($"{chapter_choose.Text}.html doesnot exist in Installation Directory.", "ERROR!!");
            }
        }
        private void frmdelete_Load(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

            installdir = regkey.GetValue("installdir").ToString();

            chapter_choose.SelectedIndex = 0;
        }   
    }
}
