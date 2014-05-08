namespace Timer
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
	        this.components = new System.ComponentModel.Container();
	        this.label1 = new System.Windows.Forms.Label();
	        this.groupBox1 = new System.Windows.Forms.GroupBox();
	        this.textBox3 = new System.Windows.Forms.TextBox();
	        this.label5 = new System.Windows.Forms.Label();
	        this.radiotimer = new System.Windows.Forms.RadioButton();
	        this.textBox2 = new System.Windows.Forms.TextBox();
	        this.radiostopwatch = new System.Windows.Forms.RadioButton();
	        this.label4 = new System.Windows.Forms.Label();
	        this.radiowatch = new System.Windows.Forms.RadioButton();
	        this.textBox1 = new System.Windows.Forms.TextBox();
	        this.label3 = new System.Windows.Forms.Label();
	        this.label2 = new System.Windows.Forms.Label();
	        this.button1 = new System.Windows.Forms.Button();
	        this.button2 = new System.Windows.Forms.Button();
	        this.timerwatch = new System.Windows.Forms.Timer(this.components);
	        this.timerstopwatch = new System.Windows.Forms.Timer(this.components);
	        this.timer = new System.Windows.Forms.Timer(this.components);
	        this.groupBox1.SuspendLayout();
	        this.SuspendLayout();
	        // 
	        // label1
	        // 
	        this.label1.AutoSize = true;
	        this.label1.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.label1.Location = new System.Drawing.Point(12, 53);
	        this.label1.Name = "label1";
	        this.label1.Size = new System.Drawing.Size(169, 31);
	        this.label1.TabIndex = 0;
	        this.label1.Text = "00:00:00:00";
	        // 
	        // groupBox1
	        // 
	        this.groupBox1.Controls.Add(this.textBox3);
	        this.groupBox1.Controls.Add(this.label5);
	        this.groupBox1.Controls.Add(this.radiotimer);
	        this.groupBox1.Controls.Add(this.textBox2);
	        this.groupBox1.Controls.Add(this.radiostopwatch);
	        this.groupBox1.Controls.Add(this.label4);
	        this.groupBox1.Controls.Add(this.radiowatch);
	        this.groupBox1.Controls.Add(this.textBox1);
	        this.groupBox1.Controls.Add(this.label3);
	        this.groupBox1.Location = new System.Drawing.Point(187, 24);
	        this.groupBox1.Name = "groupBox1";
	        this.groupBox1.Size = new System.Drawing.Size(136, 115);
	        this.groupBox1.TabIndex = 1;
	        this.groupBox1.TabStop = false;
	        this.groupBox1.Text = "기능";
	        // 
	        // textBox3
	        // 
	        this.textBox3.Location = new System.Drawing.Point(89, 88);
	        this.textBox3.Name = "textBox3";
	        this.textBox3.Size = new System.Drawing.Size(25, 21);
	        this.textBox3.TabIndex = 8;
	        // 
	        // label5
	        // 
	        this.label5.AutoSize = true;
	        this.label5.Location = new System.Drawing.Point(113, 91);
	        this.label5.Name = "label5";
	        this.label5.Size = new System.Drawing.Size(17, 12);
	        this.label5.TabIndex = 9;
	        this.label5.Text = "초";
	        // 
	        // radiotimer
	        // 
	        this.radiotimer.AutoSize = true;
	        this.radiotimer.Location = new System.Drawing.Point(6, 64);
	        this.radiotimer.Name = "radiotimer";
	        this.radiotimer.Size = new System.Drawing.Size(59, 16);
	        this.radiotimer.TabIndex = 2;
	        this.radiotimer.TabStop = true;
	        this.radiotimer.Text = "타이머";
	        this.radiotimer.UseVisualStyleBackColor = true;
	        // 
	        // textBox2
	        // 
	        this.textBox2.Location = new System.Drawing.Point(47, 88);
	        this.textBox2.Name = "textBox2";
	        this.textBox2.Size = new System.Drawing.Size(25, 21);
	        this.textBox2.TabIndex = 6;
	        // 
	        // radiostopwatch
	        // 
	        this.radiostopwatch.AutoSize = true;
	        this.radiostopwatch.Location = new System.Drawing.Point(6, 42);
	        this.radiostopwatch.Name = "radiostopwatch";
	        this.radiostopwatch.Size = new System.Drawing.Size(71, 16);
	        this.radiostopwatch.TabIndex = 1;
	        this.radiostopwatch.TabStop = true;
	        this.radiostopwatch.Text = "스톱워치";
	        this.radiostopwatch.UseVisualStyleBackColor = true;
	        // 
	        // label4
	        // 
	        this.label4.AutoSize = true;
	        this.label4.Location = new System.Drawing.Point(71, 91);
	        this.label4.Name = "label4";
	        this.label4.Size = new System.Drawing.Size(17, 12);
	        this.label4.TabIndex = 7;
	        this.label4.Text = "분";
	        // 
	        // radiowatch
	        // 
	        this.radiowatch.AutoSize = true;
	        this.radiowatch.Location = new System.Drawing.Point(6, 20);
	        this.radiowatch.Name = "radiowatch";
	        this.radiowatch.Size = new System.Drawing.Size(47, 16);
	        this.radiowatch.TabIndex = 0;
	        this.radiowatch.TabStop = true;
	        this.radiowatch.Text = "시계";
	        this.radiowatch.UseVisualStyleBackColor = true;
	        this.radiowatch.CheckedChanged += new System.EventHandler(this.radiowatch_CheckedChanged);
	        // 
	        // textBox1
	        // 
	        this.textBox1.Location = new System.Drawing.Point(6, 88);
	        this.textBox1.Name = "textBox1";
	        this.textBox1.Size = new System.Drawing.Size(25, 21);
	        this.textBox1.TabIndex = 3;
	        // 
	        // label3
	        // 
	        this.label3.AutoSize = true;
	        this.label3.Location = new System.Drawing.Point(30, 91);
	        this.label3.Name = "label3";
	        this.label3.Size = new System.Drawing.Size(17, 12);
	        this.label3.TabIndex = 5;
	        this.label3.Text = "시";
	        // 
	        // label2
	        // 
	        this.label2.AutoSize = true;
	        this.label2.Location = new System.Drawing.Point(16, 90);
	        this.label2.Name = "label2";
	        this.label2.Size = new System.Drawing.Size(161, 12);
	        this.label2.TabIndex = 2;
	        this.label2.Text = "--------------------------";
	        // 
	        // button1
	        // 
	        this.button1.Location = new System.Drawing.Point(14, 24);
	        this.button1.Name = "button1";
	        this.button1.Size = new System.Drawing.Size(75, 23);
	        this.button1.TabIndex = 3;
	        this.button1.Text = "확인";
	        this.button1.UseVisualStyleBackColor = true;
	        this.button1.Click += new System.EventHandler(this.button1_Click);
	        // 
	        // button2
	        // 
	        this.button2.Location = new System.Drawing.Point(95, 24);
	        this.button2.Name = "button2";
	        this.button2.Size = new System.Drawing.Size(75, 23);
	        this.button2.TabIndex = 4;
	        this.button2.Text = "리셋";
	        this.button2.UseVisualStyleBackColor = true;
	        this.button2.Click += new System.EventHandler(this.button2_Click);
	        // 
	        // timerwatch
	        // 
	        this.timerwatch.Tick += new System.EventHandler(this.timerwatch_Tick);
	        // 
	        // timerstopwatch
	        // 
	        this.timerstopwatch.Tick += new System.EventHandler(this.timerstopwatch_Tick);
	        // 
	        // timer
	        // 
	        this.timer.Tick += new System.EventHandler(this.timer_Tick);
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(332, 241);
	        this.Controls.Add(this.button2);
	        this.Controls.Add(this.button1);
	        this.Controls.Add(this.label2);
	        this.Controls.Add(this.groupBox1);
	        this.Controls.Add(this.label1);
	        this.Name = "Form1";
	        this.Text = "쓰잘떼기없는 프로그램";
	        this.Load += new System.EventHandler(this.Form1_Load);
	        this.groupBox1.ResumeLayout(false);
	        this.groupBox1.PerformLayout();
	        this.ResumeLayout(false);
	        this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.RadioButton radiotimer;
	private System.Windows.Forms.RadioButton radiostopwatch;
	private System.Windows.Forms.RadioButton radiowatch;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Timer timerwatch;
	private System.Windows.Forms.Timer timerstopwatch;
	private System.Windows.Forms.Timer timer;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox textBox3;
	private System.Windows.Forms.Label label5;
        }
}

