namespace QustionBankOne
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmdReadRemote = new System.Windows.Forms.Button();
            this.cmdWriteRemote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "First Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdReadRemote
            // 
            this.cmdReadRemote.Location = new System.Drawing.Point(27, 109);
            this.cmdReadRemote.Name = "cmdReadRemote";
            this.cmdReadRemote.Size = new System.Drawing.Size(194, 53);
            this.cmdReadRemote.TabIndex = 1;
            this.cmdReadRemote.Text = "Read";
            this.cmdReadRemote.UseVisualStyleBackColor = true;
            this.cmdReadRemote.Click += new System.EventHandler(this.cmdReadRemote_Click);
            // 
            // cmdWriteRemote
            // 
            this.cmdWriteRemote.Location = new System.Drawing.Point(27, 425);
            this.cmdWriteRemote.Name = "cmdWriteRemote";
            this.cmdWriteRemote.Size = new System.Drawing.Size(194, 53);
            this.cmdWriteRemote.TabIndex = 2;
            this.cmdWriteRemote.Text = "Write";
            this.cmdWriteRemote.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(839, 234);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 660);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdWriteRemote);
            this.Controls.Add(this.cmdReadRemote);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdReadRemote;
        private System.Windows.Forms.Button cmdWriteRemote;
        private System.Windows.Forms.TextBox textBox1;
    }
}

