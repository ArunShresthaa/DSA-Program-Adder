
namespace Program_Adder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.youtube = new System.Windows.Forms.PictureBox();
            this.website = new System.Windows.Forms.PictureBox();
            this.github = new System.Windows.Forms.PictureBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btninstall = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btninstall);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 163);
            this.panel2.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblusername.Location = new System.Drawing.Point(38, 98);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(97, 20);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "UserName";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minimize_btn);
            this.panel3.Controls.Add(this.youtube);
            this.panel3.Controls.Add(this.website);
            this.panel3.Controls.Add(this.github);
            this.panel3.Controls.Add(this.PnlFormLoader);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Title);
            this.panel3.Location = new System.Drawing.Point(184, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 577);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(674, 12);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(45, 32);
            this.minimize_btn.TabIndex = 5;
            this.minimize_btn.Text = "--";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(0, 81);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(766, 496);
            this.PnlFormLoader.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(722, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title.Location = new System.Drawing.Point(20, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Dashboard";
            // 
            // youtube
            // 
            this.youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtube.Image = global::Program_Adder.Properties.Resources.youtube1;
            this.youtube.Location = new System.Drawing.Point(562, 22);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(34, 32);
            this.youtube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.youtube.TabIndex = 4;
            this.youtube.TabStop = false;
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // website
            // 
            this.website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.website.Image = global::Program_Adder.Properties.Resources.final_website;
            this.website.Location = new System.Drawing.Point(517, 24);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(34, 32);
            this.website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.website.TabIndex = 4;
            this.website.TabStop = false;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // github
            // 
            this.github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github.Image = global::Program_Adder.Properties.Resources.github1;
            this.github.Location = new System.Drawing.Point(608, 22);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(34, 32);
            this.github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.github.TabIndex = 4;
            this.github.TabStop = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // btnedit
            // 
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnedit.Image = global::Program_Adder.Properties.Resources.final_edit;
            this.btnedit.Location = new System.Drawing.Point(0, 289);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(186, 42);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit         ";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btninstall
            // 
            this.btninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninstall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btninstall.FlatAppearance.BorderSize = 0;
            this.btninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstall.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btninstall.Image = global::Program_Adder.Properties.Resources.settingicon;
            this.btninstall.Location = new System.Drawing.Point(0, 535);
            this.btninstall.Name = "btninstall";
            this.btninstall.Size = new System.Drawing.Size(186, 42);
            this.btninstall.TabIndex = 3;
            this.btninstall.Text = "Install";
            this.btninstall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btninstall.UseVisualStyleBackColor = true;
            this.btninstall.Click += new System.EventHandler(this.btninstall_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndelete.Image = global::Program_Adder.Properties.Resources.deleteicon1;
            this.btndelete.Location = new System.Drawing.Point(0, 247);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(186, 42);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete    ";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnadd.Image = global::Program_Adder.Properties.Resources.addicon;
            this.btnadd.Location = new System.Drawing.Point(0, 205);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 42);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add         ";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndashboard.Image = global::Program_Adder.Properties.Resources.dashboard5;
            this.btndashboard.Location = new System.Drawing.Point(0, 163);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(186, 42);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Program_Adder.Properties.Resources.DSA;
            this.pictureBox1.Location = new System.Drawing.Point(56, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSA Website";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.website)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.PictureBox github;
        private System.Windows.Forms.PictureBox youtube;
        private System.Windows.Forms.PictureBox website;
        private System.Windows.Forms.Button btninstall;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button minimize_btn;
    }
}

