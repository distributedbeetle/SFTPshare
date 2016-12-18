namespace SFTPshare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadBut = new System.Windows.Forms.Button();
            this.browseTextBox = new System.Windows.Forms.TextBox();
            this.browseBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.downloadBut = new System.Windows.Forms.Button();
            this.retrieveListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.retrieveBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uploadBut);
            this.groupBox1.Controls.Add(this.browseTextBox);
            this.groupBox1.Controls.Add(this.browseBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload a File";
            // 
            // uploadBut
            // 
            this.uploadBut.Location = new System.Drawing.Point(16, 130);
            this.uploadBut.Name = "uploadBut";
            this.uploadBut.Size = new System.Drawing.Size(106, 44);
            this.uploadBut.TabIndex = 2;
            this.uploadBut.Text = "Upload File";
            this.uploadBut.UseVisualStyleBackColor = true;
            this.uploadBut.Click += new System.EventHandler(this.uploadBut_Click);
            // 
            // browseTextBox
            // 
            this.browseTextBox.Location = new System.Drawing.Point(16, 80);
            this.browseTextBox.Name = "browseTextBox";
            this.browseTextBox.Size = new System.Drawing.Size(291, 20);
            this.browseTextBox.TabIndex = 1;
            // 
            // browseBut
            // 
            this.browseBut.Location = new System.Drawing.Point(16, 30);
            this.browseBut.Name = "browseBut";
            this.browseBut.Size = new System.Drawing.Size(106, 44);
            this.browseBut.TabIndex = 0;
            this.browseBut.Text = "Browse File";
            this.browseBut.UseVisualStyleBackColor = true;
            this.browseBut.Click += new System.EventHandler(this.browseBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.retrieveBut);
            this.groupBox2.Controls.Add(this.downloadBut);
            this.groupBox2.Controls.Add(this.retrieveListBox);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download a File";
            // 
            // downloadBut
            // 
            this.downloadBut.Location = new System.Drawing.Point(6, 220);
            this.downloadBut.Name = "downloadBut";
            this.downloadBut.Size = new System.Drawing.Size(106, 44);
            this.downloadBut.TabIndex = 1;
            this.downloadBut.Text = "Download File";
            this.downloadBut.UseVisualStyleBackColor = true;
            this.downloadBut.Click += new System.EventHandler(this.downloadBut_Click);
            // 
            // retrieveListBox
            // 
            this.retrieveListBox.FormattingEnabled = true;
            this.retrieveListBox.Location = new System.Drawing.Point(7, 80);
            this.retrieveListBox.Name = "retrieveListBox";
            this.retrieveListBox.Size = new System.Drawing.Size(246, 134);
            this.retrieveListBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // retrieveBut
            // 
            this.retrieveBut.Location = new System.Drawing.Point(6, 30);
            this.retrieveBut.Name = "retrieveBut";
            this.retrieveBut.Size = new System.Drawing.Size(106, 44);
            this.retrieveBut.TabIndex = 2;
            this.retrieveBut.Text = "Retrieve Files";
            this.retrieveBut.UseVisualStyleBackColor = true;
            this.retrieveBut.Click += new System.EventHandler(this.retrieveBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(243, 310);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(106, 44);
            this.exitBut.TabIndex = 3;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 360);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AWS Suse FTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadBut;
        private System.Windows.Forms.TextBox browseTextBox;
        private System.Windows.Forms.Button browseBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button downloadBut;
        private System.Windows.Forms.ListBox retrieveListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button retrieveBut;
        private System.Windows.Forms.Button exitBut;
    }
}

