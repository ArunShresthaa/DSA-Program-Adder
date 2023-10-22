using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Program_Adder
{
    public partial class frmedit : Form
    {
        string installdir;
        string strclipboard;
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

        public frmedit()
        {
            InitializeComponent();

            openbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, openbtn.Width, openbtn.Height, 20, 20));
            question.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, question.Width, question.Height, 10, 10));
            chapter_choose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chapter_choose.Width, chapter_choose.Height, 10, 10));
            raw_replace_code.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, raw_replace_code.Width, raw_replace_code.Height, 20, 20));
            processed_replace_code.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, processed_replace_code.Width, processed_replace_code.Height, 20, 20));
            btn_process_code.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_process_code.Width, btn_process_code.Height, 20, 20));
            btn_firstpart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_firstpart.Width, btn_firstpart.Height, 20, 20));
            btn_secondpart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_secondpart.Width, btn_secondpart.Height, 20, 20));
            code_no.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, code_no.Width, code_no.Height, 20, 20));
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            //Performing Checks.
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

            //Actions to Perform if all Checks are Clear.

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
            
                string hreffp = $@"{installdir}\Programs\{chapter_choose.Text}\{hreffilename}.html"; //Making Href filepath
                if (File.Exists(hreffp))
                {
                    //opening with sublime text editor
                    Process.Start("subl", $"\"{hreffp}\"");
                    //finished opening file with sublime

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

        private void frmedit_Load(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.
            installdir = regkey.GetValue("installdir").ToString();

            code_no.Text = "2";
            chapter_choose.SelectedIndex = 0;
        }

        private void btn_process_code_Click(object sender, EventArgs e)
        {
            string usercode = raw_replace_code.Text;

            string[] to_be_replaced = { "&", "<", ">" };
            string[] replaced_by = { "&amp", "&lt", "&gt" };

            if (to_be_replaced.Length == replaced_by.Length)
            {
                for (int i = 0; i < to_be_replaced.Length; i++)
                {
                    usercode = usercode.Replace(to_be_replaced[i], replaced_by[i]);
                }
            }
            else
            {
                MessageBox.Show("Length of to_be_replaced != Length of replaced_by !!", "Error !!!");
                return;
            }
            string finalcode = usercode;

            processed_replace_code.Text = finalcode;
            strclipboard = finalcode;
            copy_to_clipboard();
            SystemSounds.Asterisk.Play();
        }

        //creating thread to copy to clipboard.
        public void somethingToRunInThread_of_copy_to_clipboard()
        {
            Clipboard.SetText(strclipboard);
        }

        protected void copy_to_clipboard()
        {
            Thread clipboardThread = new Thread(somethingToRunInThread_of_copy_to_clipboard);
            clipboardThread.SetApartmentState(ApartmentState.STA);
            clipboardThread.IsBackground = false;
            clipboardThread.Start();
        }

        private void btn_firstpart_Click(object sender, EventArgs e)
        {
            strclipboard = $"<li class=\"nav-item\" role=\"presentation\"> <a class=\"nav-link\" id=\"code{code_no.Text}-tab\" data-toggle=\"tab\" href=\"#code{code_no.Text}\" role=\"tab\" aria-controls=\"Outlines\" aria-selected=\"true\">Code {code_no.Text}</a> </li> <!--Here1-->     ";
            copy_to_clipboard();
            SystemSounds.Asterisk.Play();
        }

        private void btn_secondpart_Click(object sender, EventArgs e)
        {
            strclipboard = $"<div class=\"tab-pane fade show\" id=\"code{code_no.Text}\" role=\"tabpanel\" aria-labelledby=\"code{code_no.Text}-tab\"> <pre><code class=\"language-cpp\">CODE</code></pre> </div> <!--Here1-->     ";
            copy_to_clipboard();
            SystemSounds.Asterisk.Play();
        }
    }
}
