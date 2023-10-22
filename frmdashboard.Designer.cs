
namespace Program_Adder
{
    partial class frmdashboard
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
            this.btnopen_site = new System.Windows.Forms.Button();
            this.commit_changes_btn = new System.Windows.Forms.Button();
            this.btnopen_lab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnopen_site
            // 
            this.btnopen_site.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnopen_site.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopen_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen_site.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnopen_site.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnopen_site.Location = new System.Drawing.Point(157, 158);
            this.btnopen_site.Name = "btnopen_site";
            this.btnopen_site.Size = new System.Drawing.Size(127, 79);
            this.btnopen_site.TabIndex = 0;
            this.btnopen_site.Text = "Open Website";
            this.btnopen_site.UseVisualStyleBackColor = false;
            this.btnopen_site.Click += new System.EventHandler(this.btnopen_site_Click);
            // 
            // commit_changes_btn
            // 
            this.commit_changes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.commit_changes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commit_changes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commit_changes_btn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.commit_changes_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.commit_changes_btn.Location = new System.Drawing.Point(308, 286);
            this.commit_changes_btn.Name = "commit_changes_btn";
            this.commit_changes_btn.Size = new System.Drawing.Size(127, 79);
            this.commit_changes_btn.TabIndex = 1;
            this.commit_changes_btn.Text = "Commit Changes";
            this.commit_changes_btn.UseVisualStyleBackColor = false;
            this.commit_changes_btn.Click += new System.EventHandler(this.commit_changes_btn_Click);
            // 
            // btnopen_lab
            // 
            this.btnopen_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnopen_lab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnopen_lab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen_lab.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnopen_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnopen_lab.Location = new System.Drawing.Point(462, 158);
            this.btnopen_lab.Name = "btnopen_lab";
            this.btnopen_lab.Size = new System.Drawing.Size(127, 79);
            this.btnopen_lab.TabIndex = 2;
            this.btnopen_lab.Text = "Open Lab";
            this.btnopen_lab.UseVisualStyleBackColor = false;
            this.btnopen_lab.Click += new System.EventHandler(this.btnopen_lab_Click);
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.btnopen_lab);
            this.Controls.Add(this.commit_changes_btn);
            this.Controls.Add(this.btnopen_site);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdashboard";
            this.Text = "frmdashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen_site;
        private System.Windows.Forms.Button commit_changes_btn;
        private System.Windows.Forms.Button btnopen_lab;
    }
}