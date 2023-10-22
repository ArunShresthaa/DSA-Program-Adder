
namespace Program_Adder
{
    partial class frmedit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chapter_choose = new System.Windows.Forms.ComboBox();
            this.question = new System.Windows.Forms.TextBox();
            this.openbtn = new System.Windows.Forms.Button();
            this.raw_replace_code = new System.Windows.Forms.TextBox();
            this.processed_replace_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_process_code = new System.Windows.Forms.Button();
            this.btn_firstpart = new System.Windows.Forms.Button();
            this.btn_secondpart = new System.Windows.Forms.Button();
            this.code_no = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enter Question:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Choose Chapter:";
            // 
            // chapter_choose
            // 
            this.chapter_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.chapter_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chapter_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapter_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapter_choose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chapter_choose.FormattingEnabled = true;
            this.chapter_choose.Items.AddRange(new object[] {
            "Lab"});
            this.chapter_choose.Location = new System.Drawing.Point(56, 54);
            this.chapter_choose.Name = "chapter_choose";
            this.chapter_choose.Size = new System.Drawing.Size(185, 28);
            this.chapter_choose.TabIndex = 28;
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.question.Location = new System.Drawing.Point(56, 131);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(658, 31);
            this.question.TabIndex = 27;
            // 
            // openbtn
            // 
            this.openbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.openbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openbtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.openbtn.Location = new System.Drawing.Point(313, 168);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(152, 58);
            this.openbtn.TabIndex = 26;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = false;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // raw_replace_code
            // 
            this.raw_replace_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.raw_replace_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.raw_replace_code.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.raw_replace_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.raw_replace_code.Location = new System.Drawing.Point(12, 232);
            this.raw_replace_code.Multiline = true;
            this.raw_replace_code.Name = "raw_replace_code";
            this.raw_replace_code.Size = new System.Drawing.Size(374, 181);
            this.raw_replace_code.TabIndex = 31;
            // 
            // processed_replace_code
            // 
            this.processed_replace_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.processed_replace_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processed_replace_code.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.processed_replace_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.processed_replace_code.Location = new System.Drawing.Point(392, 232);
            this.processed_replace_code.Multiline = true;
            this.processed_replace_code.Name = "processed_replace_code";
            this.processed_replace_code.Size = new System.Drawing.Size(362, 181);
            this.processed_replace_code.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(85, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Raw Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(503, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Processed Code";
            // 
            // btn_process_code
            // 
            this.btn_process_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_process_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_process_code.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_process_code.Location = new System.Drawing.Point(299, 426);
            this.btn_process_code.Name = "btn_process_code";
            this.btn_process_code.Size = new System.Drawing.Size(195, 58);
            this.btn_process_code.TabIndex = 35;
            this.btn_process_code.Text = "Process Code";
            this.btn_process_code.UseVisualStyleBackColor = false;
            this.btn_process_code.Click += new System.EventHandler(this.btn_process_code_Click);
            // 
            // btn_firstpart
            // 
            this.btn_firstpart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_firstpart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_firstpart.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_firstpart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_firstpart.Location = new System.Drawing.Point(512, 34);
            this.btn_firstpart.Name = "btn_firstpart";
            this.btn_firstpart.Size = new System.Drawing.Size(92, 58);
            this.btn_firstpart.TabIndex = 36;
            this.btn_firstpart.Text = "Part1";
            this.btn_firstpart.UseVisualStyleBackColor = false;
            this.btn_firstpart.Click += new System.EventHandler(this.btn_firstpart_Click);
            // 
            // btn_secondpart
            // 
            this.btn_secondpart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_secondpart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_secondpart.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_secondpart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_secondpart.Location = new System.Drawing.Point(610, 34);
            this.btn_secondpart.Name = "btn_secondpart";
            this.btn_secondpart.Size = new System.Drawing.Size(104, 58);
            this.btn_secondpart.TabIndex = 37;
            this.btn_secondpart.Text = "Part 2";
            this.btn_secondpart.UseVisualStyleBackColor = false;
            this.btn_secondpart.Click += new System.EventHandler(this.btn_secondpart_Click);
            // 
            // code_no
            // 
            this.code_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.code_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code_no.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.code_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.code_no.Location = new System.Drawing.Point(455, 48);
            this.code_no.Name = "code_no";
            this.code_no.Size = new System.Drawing.Size(51, 31);
            this.code_no.TabIndex = 38;
            // 
            // frmedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.code_no);
            this.Controls.Add(this.btn_secondpart);
            this.Controls.Add(this.btn_firstpart);
            this.Controls.Add(this.btn_process_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processed_replace_code);
            this.Controls.Add(this.raw_replace_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chapter_choose);
            this.Controls.Add(this.question);
            this.Controls.Add(this.openbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmedit";
            this.Text = "frmedit";
            this.Load += new System.EventHandler(this.frmedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chapter_choose;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.TextBox raw_replace_code;
        private System.Windows.Forms.TextBox processed_replace_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_process_code;
        private System.Windows.Forms.Button btn_firstpart;
        private System.Windows.Forms.Button btn_secondpart;
        private System.Windows.Forms.TextBox code_no;
    }
}