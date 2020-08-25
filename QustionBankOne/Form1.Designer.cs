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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cmdReadRemote = new System.Windows.Forms.Button();
            this.cmdWriteRemote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdReadImage = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImageBase64 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "First Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdReadRemote
            // 
            this.cmdReadRemote.Location = new System.Drawing.Point(27, 104);
            this.cmdReadRemote.Name = "cmdReadRemote";
            this.cmdReadRemote.Size = new System.Drawing.Size(165, 32);
            this.cmdReadRemote.TabIndex = 1;
            this.cmdReadRemote.Text = "Read";
            this.cmdReadRemote.UseVisualStyleBackColor = true;
            this.cmdReadRemote.Click += new System.EventHandler(this.cmdReadRemote_Click);
            // 
            // cmdWriteRemote
            // 
            this.cmdWriteRemote.Location = new System.Drawing.Point(27, 247);
            this.cmdWriteRemote.Name = "cmdWriteRemote";
            this.cmdWriteRemote.Size = new System.Drawing.Size(165, 32);
            this.cmdWriteRemote.TabIndex = 2;
            this.cmdWriteRemote.Text = "Write";
            this.cmdWriteRemote.UseVisualStyleBackColor = true;
            this.cmdWriteRemote.Click += new System.EventHandler(this.cmdWriteRemote_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(872, 100);
            this.textBox1.TabIndex = 3;
            // 
            // cmdReadImage
            // 
            this.cmdReadImage.Location = new System.Drawing.Point(27, 370);
            this.cmdReadImage.Name = "cmdReadImage";
            this.cmdReadImage.Size = new System.Drawing.Size(165, 32);
            this.cmdReadImage.TabIndex = 4;
            this.cmdReadImage.Text = "Show Image";
            this.cmdReadImage.UseVisualStyleBackColor = true;
            this.cmdReadImage.Click += new System.EventHandler(this.cmdReadImage_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(872, 79);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "{ \"_id\" : ObjectId(\"5f4265b8d12ee81a1490c508\"), \"Question\" : \"Sample Question\", \"" +
    "Image\" : new BinData(0, \"\"), \"Options\" : [\"1\", \"2\", \"3\", \"4\", \"Option 5\"], \"Answ" +
    "er\" : \"2\" }";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(844, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtImageBase64
            // 
            this.txtImageBase64.Location = new System.Drawing.Point(248, 370);
            this.txtImageBase64.Multiline = true;
            this.txtImageBase64.Name = "txtImageBase64";
            this.txtImageBase64.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtImageBase64.Size = new System.Drawing.Size(590, 234);
            this.txtImageBase64.TabIndex = 7;
            this.txtImageBase64.Text = resources.GetString("txtImageBase64.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 645);
            this.Controls.Add(this.txtImageBase64);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmdReadImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdWriteRemote);
            this.Controls.Add(this.cmdReadRemote);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdReadRemote;
        private System.Windows.Forms.Button cmdWriteRemote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdReadImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtImageBase64;
    }
}

