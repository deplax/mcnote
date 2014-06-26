namespace CalcGUI
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
	        this.txtlcd = new System.Windows.Forms.TextBox();
	        this.btSin = new System.Windows.Forms.Button();
	        this.btCos = new System.Windows.Forms.Button();
	        this.btTan = new System.Windows.Forms.Button();
	        this.btAC = new System.Windows.Forms.Button();
	        this.bt01 = new System.Windows.Forms.Button();
	        this.bt02 = new System.Windows.Forms.Button();
	        this.bt03 = new System.Windows.Forms.Button();
	        this.btPlus = new System.Windows.Forms.Button();
	        this.bt04 = new System.Windows.Forms.Button();
	        this.bt05 = new System.Windows.Forms.Button();
	        this.bt06 = new System.Windows.Forms.Button();
	        this.btminus = new System.Windows.Forms.Button();
	        this.bt07 = new System.Windows.Forms.Button();
	        this.bt08 = new System.Windows.Forms.Button();
	        this.bt09 = new System.Windows.Forms.Button();
	        this.btmul = new System.Windows.Forms.Button();
	        this.bt00 = new System.Windows.Forms.Button();
	        this.btDot = new System.Windows.Forms.Button();
	        this.btdiv = new System.Windows.Forms.Button();
	        this.btEqual = new System.Windows.Forms.Button();
	        this.btOp = new System.Windows.Forms.Button();
	        this.btCl = new System.Windows.Forms.Button();
	        this.button1 = new System.Windows.Forms.Button();
	        this.button2 = new System.Windows.Forms.Button();
	        this.button3 = new System.Windows.Forms.Button();
	        this.SuspendLayout();
	        // 
	        // txtlcd
	        // 
	        this.txtlcd.BackColor = System.Drawing.Color.DimGray;
	        this.txtlcd.BorderStyle = System.Windows.Forms.BorderStyle.None;
	        this.txtlcd.Font = new System.Drawing.Font("NanumGothicExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.txtlcd.Location = new System.Drawing.Point(12, 31);
	        this.txtlcd.Name = "txtlcd";
	        this.txtlcd.ReadOnly = true;
	        this.txtlcd.Size = new System.Drawing.Size(302, 25);
	        this.txtlcd.TabIndex = 0;
	        // 
	        // btSin
	        // 
	        this.btSin.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btSin.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btSin.Location = new System.Drawing.Point(12, 85);
	        this.btSin.Name = "btSin";
	        this.btSin.Size = new System.Drawing.Size(71, 54);
	        this.btSin.TabIndex = 1;
	        this.btSin.Text = "Sin";
	        this.btSin.UseVisualStyleBackColor = true;
	        this.btSin.Click += new System.EventHandler(this.btSin_Click);
	        // 
	        // btCos
	        // 
	        this.btCos.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btCos.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btCos.Location = new System.Drawing.Point(89, 85);
	        this.btCos.Name = "btCos";
	        this.btCos.Size = new System.Drawing.Size(71, 54);
	        this.btCos.TabIndex = 2;
	        this.btCos.Text = "Cos";
	        this.btCos.UseVisualStyleBackColor = true;
	        this.btCos.Click += new System.EventHandler(this.btCos_Click);
	        // 
	        // btTan
	        // 
	        this.btTan.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btTan.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btTan.Location = new System.Drawing.Point(166, 85);
	        this.btTan.Name = "btTan";
	        this.btTan.Size = new System.Drawing.Size(71, 54);
	        this.btTan.TabIndex = 3;
	        this.btTan.Text = "Tan";
	        this.btTan.UseVisualStyleBackColor = true;
	        this.btTan.Click += new System.EventHandler(this.btTan_Click);
	        // 
	        // btAC
	        // 
	        this.btAC.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btAC.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btAC.Location = new System.Drawing.Point(243, 85);
	        this.btAC.Name = "btAC";
	        this.btAC.Size = new System.Drawing.Size(71, 54);
	        this.btAC.TabIndex = 4;
	        this.btAC.Text = "AC";
	        this.btAC.UseVisualStyleBackColor = true;
	        this.btAC.Click += new System.EventHandler(this.btAC_Click);
	        // 
	        // bt01
	        // 
	        this.bt01.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt01.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt01.Location = new System.Drawing.Point(12, 205);
	        this.bt01.Name = "bt01";
	        this.bt01.Size = new System.Drawing.Size(71, 54);
	        this.bt01.TabIndex = 5;
	        this.bt01.Text = "1";
	        this.bt01.UseVisualStyleBackColor = true;
	        this.bt01.Click += new System.EventHandler(this.bt01_Click);
	        // 
	        // bt02
	        // 
	        this.bt02.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt02.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt02.Location = new System.Drawing.Point(89, 205);
	        this.bt02.Name = "bt02";
	        this.bt02.Size = new System.Drawing.Size(71, 54);
	        this.bt02.TabIndex = 6;
	        this.bt02.Text = "2";
	        this.bt02.UseVisualStyleBackColor = true;
	        this.bt02.Click += new System.EventHandler(this.bt02_Click);
	        // 
	        // bt03
	        // 
	        this.bt03.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt03.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt03.Location = new System.Drawing.Point(166, 205);
	        this.bt03.Name = "bt03";
	        this.bt03.Size = new System.Drawing.Size(71, 54);
	        this.bt03.TabIndex = 7;
	        this.bt03.Text = "3";
	        this.bt03.UseVisualStyleBackColor = true;
	        this.bt03.Click += new System.EventHandler(this.bt03_Click);
	        // 
	        // btPlus
	        // 
	        this.btPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btPlus.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btPlus.Location = new System.Drawing.Point(12, 145);
	        this.btPlus.Name = "btPlus";
	        this.btPlus.Size = new System.Drawing.Size(71, 54);
	        this.btPlus.TabIndex = 8;
	        this.btPlus.Text = "+";
	        this.btPlus.UseVisualStyleBackColor = true;
	        this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
	        // 
	        // bt04
	        // 
	        this.bt04.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt04.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt04.Location = new System.Drawing.Point(12, 265);
	        this.bt04.Name = "bt04";
	        this.bt04.Size = new System.Drawing.Size(71, 54);
	        this.bt04.TabIndex = 9;
	        this.bt04.Text = "4";
	        this.bt04.UseVisualStyleBackColor = true;
	        this.bt04.Click += new System.EventHandler(this.bt04_Click);
	        // 
	        // bt05
	        // 
	        this.bt05.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt05.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt05.Location = new System.Drawing.Point(89, 265);
	        this.bt05.Name = "bt05";
	        this.bt05.Size = new System.Drawing.Size(71, 54);
	        this.bt05.TabIndex = 10;
	        this.bt05.Text = "5";
	        this.bt05.UseVisualStyleBackColor = true;
	        this.bt05.Click += new System.EventHandler(this.bt05_Click);
	        // 
	        // bt06
	        // 
	        this.bt06.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt06.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt06.Location = new System.Drawing.Point(166, 265);
	        this.bt06.Name = "bt06";
	        this.bt06.Size = new System.Drawing.Size(71, 54);
	        this.bt06.TabIndex = 11;
	        this.bt06.Text = "6";
	        this.bt06.UseVisualStyleBackColor = true;
	        this.bt06.Click += new System.EventHandler(this.bt06_Click);
	        // 
	        // btminus
	        // 
	        this.btminus.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btminus.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btminus.Location = new System.Drawing.Point(89, 145);
	        this.btminus.Name = "btminus";
	        this.btminus.Size = new System.Drawing.Size(71, 54);
	        this.btminus.TabIndex = 12;
	        this.btminus.Text = "-";
	        this.btminus.UseVisualStyleBackColor = true;
	        this.btminus.Click += new System.EventHandler(this.btminus_Click);
	        // 
	        // bt07
	        // 
	        this.bt07.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt07.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt07.Location = new System.Drawing.Point(12, 325);
	        this.bt07.Name = "bt07";
	        this.bt07.Size = new System.Drawing.Size(71, 54);
	        this.bt07.TabIndex = 13;
	        this.bt07.Text = "7";
	        this.bt07.UseVisualStyleBackColor = true;
	        this.bt07.Click += new System.EventHandler(this.bt07_Click);
	        // 
	        // bt08
	        // 
	        this.bt08.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt08.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt08.Location = new System.Drawing.Point(89, 325);
	        this.bt08.Name = "bt08";
	        this.bt08.Size = new System.Drawing.Size(71, 54);
	        this.bt08.TabIndex = 14;
	        this.bt08.Text = "8";
	        this.bt08.UseVisualStyleBackColor = true;
	        this.bt08.Click += new System.EventHandler(this.bt08_Click);
	        // 
	        // bt09
	        // 
	        this.bt09.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt09.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt09.Location = new System.Drawing.Point(166, 325);
	        this.bt09.Name = "bt09";
	        this.bt09.Size = new System.Drawing.Size(71, 54);
	        this.bt09.TabIndex = 15;
	        this.bt09.Text = "9";
	        this.bt09.UseVisualStyleBackColor = true;
	        this.bt09.Click += new System.EventHandler(this.bt09_Click);
	        // 
	        // btmul
	        // 
	        this.btmul.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btmul.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btmul.Location = new System.Drawing.Point(166, 145);
	        this.btmul.Name = "btmul";
	        this.btmul.Size = new System.Drawing.Size(71, 54);
	        this.btmul.TabIndex = 16;
	        this.btmul.Text = "*";
	        this.btmul.UseVisualStyleBackColor = true;
	        this.btmul.Click += new System.EventHandler(this.btmul_Click);
	        // 
	        // bt00
	        // 
	        this.bt00.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.bt00.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.bt00.Location = new System.Drawing.Point(12, 385);
	        this.bt00.Name = "bt00";
	        this.bt00.Size = new System.Drawing.Size(148, 54);
	        this.bt00.TabIndex = 17;
	        this.bt00.Text = "0";
	        this.bt00.UseVisualStyleBackColor = true;
	        this.bt00.Click += new System.EventHandler(this.bt00_Click);
	        // 
	        // btDot
	        // 
	        this.btDot.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btDot.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btDot.Location = new System.Drawing.Point(166, 385);
	        this.btDot.Name = "btDot";
	        this.btDot.Size = new System.Drawing.Size(71, 54);
	        this.btDot.TabIndex = 18;
	        this.btDot.Text = ".";
	        this.btDot.UseVisualStyleBackColor = true;
	        this.btDot.Click += new System.EventHandler(this.btDot_Click);
	        // 
	        // btdiv
	        // 
	        this.btdiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btdiv.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btdiv.Location = new System.Drawing.Point(243, 145);
	        this.btdiv.Name = "btdiv";
	        this.btdiv.Size = new System.Drawing.Size(71, 54);
	        this.btdiv.TabIndex = 19;
	        this.btdiv.Text = "/";
	        this.btdiv.UseVisualStyleBackColor = true;
	        this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
	        // 
	        // btEqual
	        // 
	        this.btEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btEqual.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btEqual.Location = new System.Drawing.Point(243, 325);
	        this.btEqual.Name = "btEqual";
	        this.btEqual.Size = new System.Drawing.Size(71, 114);
	        this.btEqual.TabIndex = 20;
	        this.btEqual.Text = "=";
	        this.btEqual.UseVisualStyleBackColor = true;
	        this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
	        // 
	        // btOp
	        // 
	        this.btOp.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btOp.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btOp.Location = new System.Drawing.Point(243, 205);
	        this.btOp.Name = "btOp";
	        this.btOp.Size = new System.Drawing.Size(71, 54);
	        this.btOp.TabIndex = 21;
	        this.btOp.Text = "(";
	        this.btOp.UseVisualStyleBackColor = true;
	        this.btOp.Click += new System.EventHandler(this.btOp_Click);
	        // 
	        // btCl
	        // 
	        this.btCl.FlatStyle = System.Windows.Forms.FlatStyle.System;
	        this.btCl.Font = new System.Drawing.Font("NanumGothicExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.btCl.Location = new System.Drawing.Point(243, 265);
	        this.btCl.Name = "btCl";
	        this.btCl.Size = new System.Drawing.Size(71, 54);
	        this.btCl.TabIndex = 22;
	        this.btCl.Text = ")";
	        this.btCl.UseVisualStyleBackColor = true;
	        this.btCl.Click += new System.EventHandler(this.btCl_Click);
	        // 
	        // button1
	        // 
	        this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	        this.button1.Font = new System.Drawing.Font("NanumGothicExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.button1.Location = new System.Drawing.Point(12, 445);
	        this.button1.Name = "button1";
	        this.button1.Size = new System.Drawing.Size(83, 37);
	        this.button1.TabIndex = 23;
	        this.button1.Text = "sample01";
	        this.button1.UseVisualStyleBackColor = true;
	        this.button1.Click += new System.EventHandler(this.button1_Click);
	        // 
	        // button2
	        // 
	        this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	        this.button2.Font = new System.Drawing.Font("NanumGothicExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.button2.Location = new System.Drawing.Point(121, 445);
	        this.button2.Name = "button2";
	        this.button2.Size = new System.Drawing.Size(83, 37);
	        this.button2.TabIndex = 24;
	        this.button2.Text = "sample02";
	        this.button2.UseVisualStyleBackColor = true;
	        this.button2.Click += new System.EventHandler(this.button2_Click);
	        // 
	        // button3
	        // 
	        this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	        this.button3.Font = new System.Drawing.Font("NanumGothicExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
	        this.button3.Location = new System.Drawing.Point(230, 445);
	        this.button3.Name = "button3";
	        this.button3.Size = new System.Drawing.Size(83, 37);
	        this.button3.TabIndex = 25;
	        this.button3.Text = "sample03";
	        this.button3.UseVisualStyleBackColor = true;
	        this.button3.Click += new System.EventHandler(this.button3_Click);
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
	        this.ClientSize = new System.Drawing.Size(328, 492);
	        this.Controls.Add(this.button3);
	        this.Controls.Add(this.button2);
	        this.Controls.Add(this.button1);
	        this.Controls.Add(this.btCl);
	        this.Controls.Add(this.btOp);
	        this.Controls.Add(this.btEqual);
	        this.Controls.Add(this.btdiv);
	        this.Controls.Add(this.btDot);
	        this.Controls.Add(this.bt00);
	        this.Controls.Add(this.btmul);
	        this.Controls.Add(this.bt09);
	        this.Controls.Add(this.bt08);
	        this.Controls.Add(this.bt07);
	        this.Controls.Add(this.btminus);
	        this.Controls.Add(this.bt06);
	        this.Controls.Add(this.bt05);
	        this.Controls.Add(this.bt04);
	        this.Controls.Add(this.btPlus);
	        this.Controls.Add(this.bt03);
	        this.Controls.Add(this.bt02);
	        this.Controls.Add(this.bt01);
	        this.Controls.Add(this.btAC);
	        this.Controls.Add(this.btTan);
	        this.Controls.Add(this.btCos);
	        this.Controls.Add(this.btSin);
	        this.Controls.Add(this.txtlcd);
	        this.Name = "Form1";
	        this.Text = "Calc";
	        this.ResumeLayout(false);
	        this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TextBox txtlcd;
	private System.Windows.Forms.Button btSin;
	private System.Windows.Forms.Button btCos;
	private System.Windows.Forms.Button btTan;
	private System.Windows.Forms.Button btAC;
	private System.Windows.Forms.Button bt01;
	private System.Windows.Forms.Button bt02;
	private System.Windows.Forms.Button bt03;
	private System.Windows.Forms.Button btPlus;
	private System.Windows.Forms.Button bt04;
	private System.Windows.Forms.Button bt05;
	private System.Windows.Forms.Button bt06;
	private System.Windows.Forms.Button btminus;
	private System.Windows.Forms.Button bt07;
	private System.Windows.Forms.Button bt08;
	private System.Windows.Forms.Button bt09;
	private System.Windows.Forms.Button btmul;
	private System.Windows.Forms.Button bt00;
	private System.Windows.Forms.Button btDot;
	private System.Windows.Forms.Button btdiv;
	private System.Windows.Forms.Button btEqual;
	private System.Windows.Forms.Button btOp;
	private System.Windows.Forms.Button btCl;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button3;
        }
}

