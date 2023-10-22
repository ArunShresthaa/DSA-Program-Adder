
namespace Program_Adder
{
    partial class frmadd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.video_id = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chapter_choose = new System.Windows.Forms.ComboBox();
            this.question = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.add_from_file_btn = new System.Windows.Forms.Button();
            this.not_code = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(25, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Enter Video ID:(Leave Empty if no Video)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(25, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Paste or Drag and Drop Your Code Below:";
            // 
            // video_id
            // 
            this.video_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.video_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.video_id.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.video_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.video_id.Location = new System.Drawing.Point(60, 392);
            this.video_id.Name = "video_id";
            this.video_id.Size = new System.Drawing.Size(658, 31);
            this.video_id.TabIndex = 18;
            // 
            // code
            // 
            this.code.AllowDrop = true;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.code.Location = new System.Drawing.Point(60, 193);
            this.code.MaxLength = 999999999;
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(658, 154);
            this.code.TabIndex = 17;
            this.code.DragDrop += new System.Windows.Forms.DragEventHandler(this.code_DragDrop);
            this.code.DragEnter += new System.Windows.Forms.DragEventHandler(this.code_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Question:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 15;
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
            this.chapter_choose.Location = new System.Drawing.Point(60, 41);
            this.chapter_choose.Name = "chapter_choose";
            this.chapter_choose.Size = new System.Drawing.Size(185, 28);
            this.chapter_choose.TabIndex = 14;
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question.Font = new System.Drawing.Font("Nirmala UI", 13.8F);
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.question.Location = new System.Drawing.Point(60, 118);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(658, 31);
            this.question.TabIndex = 13;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addbtn.Location = new System.Drawing.Point(270, 440);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(144, 39);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // add_from_file_btn
            // 
            this.add_from_file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.add_from_file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_from_file_btn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_from_file_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.add_from_file_btn.Location = new System.Drawing.Point(469, 440);
            this.add_from_file_btn.Name = "add_from_file_btn";
            this.add_from_file_btn.Size = new System.Drawing.Size(231, 39);
            this.add_from_file_btn.TabIndex = 21;
            this.add_from_file_btn.Text = "ADD From File";
            this.add_from_file_btn.UseVisualStyleBackColor = false;
            this.add_from_file_btn.Click += new System.EventHandler(this.add_from_file_btn_Click);
            // 
            // not_code
            // 
            this.not_code.AutoSize = true;
            this.not_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.not_code.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.not_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.not_code.Location = new System.Drawing.Point(573, 41);
            this.not_code.Name = "not_code";
            this.not_code.Size = new System.Drawing.Size(145, 36);
            this.not_code.TabIndex = 22;
            this.not_code.Text = "Not Code";
            this.not_code.UseVisualStyleBackColor = true;
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.not_code);
            this.Controls.Add(this.add_from_file_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.video_id);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chapter_choose);
            this.Controls.Add(this.question);
            this.Controls.Add(this.addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadd";
            this.Text = "frmadd";
            this.Load += new System.EventHandler(this.frmadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox video_id;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chapter_choose;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button add_from_file_btn;
        private System.Windows.Forms.CheckBox not_code;
    }
}