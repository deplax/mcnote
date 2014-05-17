namespace ImageViewer
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
	        this.button2 = new System.Windows.Forms.Button();
	        this.pictureBox1 = new System.Windows.Forms.PictureBox();
	        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
	        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
	        this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
	        this.button3 = new System.Windows.Forms.Button();
	        this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
	        this.button4 = new System.Windows.Forms.Button();
	        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
	        this.SuspendLayout();
	        // 
	        // button1
	        // 
	        this.button1.Location = new System.Drawing.Point(12, 575);
	        this.button1.Name = "button1";
	        this.button1.Size = new System.Drawing.Size(75, 23);
	        this.button1.TabIndex = 0;
	        this.button1.Text = "불러오기";
	        this.button1.UseVisualStyleBackColor = true;
	        this.button1.Click += new System.EventHandler(this.button1_Click);
	        // 
	        // button2
	        // 
	        this.button2.Location = new System.Drawing.Point(93, 575);
	        this.button2.Name = "button2";
	        this.button2.Size = new System.Drawing.Size(98, 23);
	        this.button2.TabIndex = 1;
	        this.button2.Text = "XML 저장하기";
	        this.button2.UseVisualStyleBackColor = true;
	        this.button2.Click += new System.EventHandler(this.button2_Click);
	        // 
	        // pictureBox1
	        // 
	        this.pictureBox1.Location = new System.Drawing.Point(12, 12);
	        this.pictureBox1.Name = "pictureBox1";
	        this.pictureBox1.Size = new System.Drawing.Size(783, 557);
	        this.pictureBox1.TabIndex = 2;
	        this.pictureBox1.TabStop = false;
	        // 
	        // openFileDialog1
	        // 
	        this.openFileDialog1.FileName = "openFileDialog1";
	        // 
	        // button3
	        // 
	        this.button3.Location = new System.Drawing.Point(278, 575);
	        this.button3.Name = "button3";
	        this.button3.Size = new System.Drawing.Size(98, 23);
	        this.button3.TabIndex = 3;
	        this.button3.Text = "XML 불러오기";
	        this.button3.UseVisualStyleBackColor = true;
	        this.button3.Click += new System.EventHandler(this.button3_Click);
	        // 
	        // openFileDialog2
	        // 
	        this.openFileDialog2.FileName = "openFileDialog2";
	        // 
	        // button4
	        // 
	        this.button4.Location = new System.Drawing.Point(197, 575);
	        this.button4.Name = "button4";
	        this.button4.Size = new System.Drawing.Size(75, 23);
	        this.button4.TabIndex = 4;
	        this.button4.Text = "지우기";
	        this.button4.UseVisualStyleBackColor = true;
	        this.button4.Click += new System.EventHandler(this.button4_Click);
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(807, 610);
	        this.Controls.Add(this.button4);
	        this.Controls.Add(this.button3);
	        this.Controls.Add(this.pictureBox1);
	        this.Controls.Add(this.button2);
	        this.Controls.Add(this.button1);
	        this.Name = "Form1";
	        this.Text = "Image";
	        this.Load += new System.EventHandler(this.Form1_Load);
	        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
	        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button4;
    }
}

