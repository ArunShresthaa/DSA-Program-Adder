using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Program_Adder
{
    public partial class frmadd : Form
    {
        string installdir;
        string codefile_path;
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

        public frmadd()
        {
            InitializeComponent();

            addbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addbtn.Width, addbtn.Height, 20, 20));
            chapter_choose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chapter_choose.Width, chapter_choose.Height, 10, 10));
            question.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, question.Width, question.Height, 10, 10));
            code.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, code.Width, code.Height, 20, 20));
            video_id.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, video_id.Width, video_id.Height, 10, 10));
            add_from_file_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add_from_file_btn.Width, add_from_file_btn.Height, 20, 20));
        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            RegistryKey regkey = BaseFolderPath;
            regkey = regkey.OpenSubKey(subkey);  //opening subkey of registry.

            installdir = regkey.GetValue("installdir").ToString();
            codefile_path = regkey.GetValue("default_file").ToString();

            chapter_choose.SelectedIndex = 0;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Performing Checks
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
            if (string.IsNullOrEmpty(code.Text))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Code cannot be Empty.", "ERROR!!");
                return;
            }
            //Finished Performing Checks.


            //Actions to Perform if all checks are clear.

            //removing illegal characters in herf filepath.
            string hreffilename = question.Text;
            string invalid = "!@#$%^&*()_+-=[]{}\\|;:'\",<.>/?`~* ";

            foreach (char c in invalid)
            {
                hreffilename = hreffilename.Replace(c.ToString(), "");
            }
            //finished removing illegal characters.

            hreffilename = new string(hreffilename.Take(maxfilesize).ToArray()); //taking only first 200 letters of question as file name
                                      
            string hreffp = $@"{installdir}\Programs\{chapter_choose.Text}\{hreffilename}.html"; //making href file path 
            if (File.Exists(hreffp))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Href File already Exists.", "Error!!!");
            }
            else
            {
                string filepath = $@"{installdir}\{chapter_choose.Text}.html";
                if (File.Exists(filepath))
                {
                    //making Href File
                    string usercode = code.Text;

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
                    string contents;
                    string video;

                    if (String.IsNullOrEmpty(video_id.Text))
                    {
                        video = "<h1>Coming Soon</h1>";
                    }
                    else
                    {
                        video = $"<iframe height=\"683\" width=\"100%\" src=\"https://www.youtube.com/embed/{video_id.Text}\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
                    }

                    if(!not_code.Checked)
                    {
                        contents = $"<!doctype html> <html lang=\"en\"> <meta http-equiv=\"content-type\" content=\"text/html;charset=utf-8\" /> <head>  <meta charset=\"utf-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><link href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/bootstrap.min.css\" rel=\"stylesheet\" /><link href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/MyStyle.css\" rel=\"stylesheet\" /><link rel=\"stylesheet\" href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/css/prism.css\" type=\"text/css\"><link rel=\"shortcut icon\" href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/images/favicon.ico\" type=\"image/x-icon\"><title>Code</title> </head> <body> <div class=\"p-3\"> <ul class=\"nav nav-tabs\" id=\"myTab\" role=\"tablist\"> <li class=\"nav-item\" role=\"presentation\"> <a class=\"nav-link active\" id=\"code-tab\" data-toggle=\"tab\" href=\"#code\" role=\"tab\" aria-controls=\"Outlines\"aria-selected=\"true\">Code</a> </li> <!--Here1-->     <!--Here2--> <li class=\"nav-item\" role=\"presentation\"> <a class=\"nav-link\" id=\"video-tab\" data-toggle=\"tab\" href=\"#video\" role=\"tab\" aria-controls=\"video\" aria-selected=\"false\">Video</a> </li> </ul> <div class=\"tab-content\" id=\"myTabContent\"> <div class=\"tab-pane fade show active\" id=\"code\" role=\"tabpanel\" aria-labelledby=\"code-tab\"> <pre><code class=\"language-cpp\">{finalcode}</code></pre> </div> <!--Here1-->     <!--Here2--> <div class=\"tab-pane fade\" id=\"video\" role=\"tabpanel\" aria-labelledby=\"video-tab\"> {video} </div> </div> </div> <script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/jquery-3.5.1.slim.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/bootstrap.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/popper.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/js/prism.js\"></script> </body> </html>";
                    }
                    else
                    {
                        contents = $"<!doctype html> <html lang=\"en\"> <meta http-equiv=\"content-type\" content=\"text/html;charset=utf-8\" /> <head>  <meta charset=\"utf-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><link href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/bootstrap.min.css\" rel=\"stylesheet\" /><link href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/MyStyle.css\" rel=\"stylesheet\" /><link rel=\"stylesheet\" href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/css/prism.css\" type=\"text/css\"><link rel=\"shortcut icon\" href=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/images/favicon.ico\" type=\"image/x-icon\"><title>Answer</title> </head> <body> <div class=\"p-3\"> <ul class=\"nav nav-tabs\" id=\"myTab\" role=\"tablist\"> <li class=\"nav-item\" role=\"presentation\"> <a class=\"nav-link active\" id=\"code-tab\" data-toggle=\"tab\" href=\"#code\" role=\"tab\" aria-controls=\"Outlines\"aria-selected=\"true\">Answer</a> </li> <!--Here1-->     <!--Here2--> <li class=\"nav-item\" role=\"presentation\"> <a class=\"nav-link\" id=\"video-tab\" data-toggle=\"tab\" href=\"#video\" role=\"tab\" aria-controls=\"video\" aria-selected=\"false\">Video</a> </li> </ul> <div class=\"tab-content\" id=\"myTabContent\"> <div class=\"tab-pane fade show active\" id=\"code\" role=\"tabpanel\" aria-labelledby=\"code-tab\">{finalcode}</div> <!--Here1-->     <!--Here2--> <div class=\"tab-pane fade\" id=\"video\" role=\"tabpanel\" aria-labelledby=\"video-tab\"> {video} </div> </div> </div> <script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/jquery-3.5.1.slim.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/bootstrap.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/Bootstrap/popper.min.js\"></script><script src=\"https://sthaarun.com.np/Dependencies-Server/DSA-Website/js/prism.js\"></script> </body> </html>";
                    }
                    
                    File.WriteAllText(hreffp, contents);
                    //finished making href file

                    //adding the question
                    string replacelocation = "<!-- next -->";
                    string hreftxt = $@"Programs/{chapter_choose.Text}/{hreffilename}.html";
                    string replacetext = $"<li><a href=\"{hreftxt}\" target=\"_blank\">{question.Text}</a></li> <!-- next -->";

                    string filecontent = File.ReadAllText(filepath);
                    string replacedcontent = filecontent.Replace(replacelocation, replacetext);
                    File.WriteAllText(filepath, replacedcontent);
                    //finished adding the question

                    MessageBox.Show("Done", "SUCCESS!!");

                    //Resetting the App
                    code.Text = "";
                    question.Text = "";
                    video_id.Text = "";
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show($"{chapter_choose.Text}.html doesnot exist in Installation Directory.", "ERROR!!");
                }

            }
        }

        private void code_DragDrop(object sender, DragEventArgs e)
        {
            SystemSounds.Asterisk.Play();

            string[] dragfilepath = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string dragfilecode = File.ReadAllText(dragfilepath[0]);
            code.Text = dragfilecode;
        }

        private void code_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void add_from_file_btn_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if(codefile_path !="not_set")
            {
                string file_code = File.ReadAllText(codefile_path);
                code.Text = file_code;
            }
            else
            {
                MessageBox.Show("Default Working File is Not Set.!!","Error !!!");
            }
        }
    }
}
