using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGUI
{
        public partial class Form1 : Form
        {
	string str;
	public Form1()
	{
	        str = "";
	        InitializeComponent();
	}

	string space(string str)
	{
	        double temp;
	        int tag = 0;
	        int[] mark = new int[str.Length];
	        for (int i = 0; i < str.Length; i++)
	        {
		if (double.TryParse(str.Substring(i, 1), out temp))       //숫자야?
		{
		        if(tag != 1)
		        {
			mark[i] = 1;
			tag = 1;
		        }
		}
		else if(str.Substring(i, 1) == ".")
		{
		        if (tag != 1)
		        {
			mark[i] = 1;
			tag = 1;
		        }
		}
		else if(str.Substring(i, 1) == "(")
		{
		        if(i != 0)
		        {
			if(double.TryParse(str.Substring(i - 1, 1), out temp))
			{
			        mark[i] = 2;
			        tag = 2;
			}
			else
			{
			        mark[i] = 1;
			        tag = 2;
			}
		        }
		        else
		        {
			mark[i] = 1;
			tag = 2;
		        }
		}
		else if(str.Substring(i, 1) == ")")
		{
		        if (i != str.Length - 1)
		        {
			if (double.TryParse(str.Substring(i + 1, 1), out temp))
			{
			        mark[i] = 2;
			        tag = 2;
			}
			else
			{
			        mark[i] = 1;
			        tag = 2;
			}
		        }
		        else
		        {
			mark[i] = 1;
			tag = 2;
		        }
		}
		else if (str.Substring(i, 1) == "+" || str.Substring(i, 1) == "/" || str.Substring(i, 1) == "*" || str.Substring(i, 1) == "-")
		{
		        tag = 3;
		        mark[i] = 1;
		}
		else 
		{
		        if(tag != 2)
		        {
			mark[i] = 1;
			tag = 2;
		        }
		}
	        }

	        for (int i = mark.Length - 1; i >= 0; i --)
	        {
		if (mark[i] == 1)
		{
		        str = str.Insert(i, " ");
		}
		else if (mark[i] == 2)
		{
		        str = str.Insert(i, " * ");
		}
	        }
	        str = str.Remove(0, 1);
	        return str;

	}

	private void bt01_Click(object sender, EventArgs e)
	{
	        str += "1";
	        txtlcd.Text = str;
	}

	private void bt02_Click(object sender, EventArgs e)
	{
	        str += "2";
	        txtlcd.Text = str;
	}

	private void bt03_Click(object sender, EventArgs e)
	{
	        str += "3";
	        txtlcd.Text = str;
	}

	private void bt04_Click(object sender, EventArgs e)
	{
	        str += "4";
	        txtlcd.Text = str;
	}

	private void bt05_Click(object sender, EventArgs e)
	{
	        str += "5";
	        txtlcd.Text = str;
	}

	private void bt06_Click(object sender, EventArgs e)
	{
	        str += "6";
	        txtlcd.Text = str;
	}

	private void bt07_Click(object sender, EventArgs e)
	{
	        str += "7";
	        txtlcd.Text = str;
	}

	private void bt08_Click(object sender, EventArgs e)
	{
	        str += "8";
	        txtlcd.Text = str;
	}

	private void bt09_Click(object sender, EventArgs e)
	{
	        str += "9";
	        txtlcd.Text = str;
	}

	private void bt00_Click(object sender, EventArgs e)
	{
	        str += "0";
	        txtlcd.Text = str;
	}

	private void btDot_Click(object sender, EventArgs e)
	{
	        str += ".";
	        txtlcd.Text = str;
	}

	private void btEqual_Click(object sender, EventArgs e)
	{
	        if (str == "")
	        {
		txtlcd.Text = "수식을 입력해주세요!";
	        }
	        else
	        {
		str = space(str);
		MakeTree mt = new MakeTree(str);
		OpNode op = mt.Making();
		txtlcd.Text = Convert.ToString(op.cal());
		str = "";
	        }
	}

	private void btCl_Click(object sender, EventArgs e)
	{
	        str += ")";
	        txtlcd.Text = str;
	}

	private void btOp_Click(object sender, EventArgs e)
	{
	        str += "(";
	        txtlcd.Text = str;
	}

	private void btdiv_Click(object sender, EventArgs e)
	{
	        str += "/";
	        txtlcd.Text = str;
	}

	private void btAC_Click(object sender, EventArgs e)
	{
	        str = "";
	        txtlcd.Text = str;
	}

	private void btTan_Click(object sender, EventArgs e)
	{
	        str += "tan";
	        txtlcd.Text = str;
	}

	private void btCos_Click(object sender, EventArgs e)
	{
	        str += "cos";
	        txtlcd.Text = str;
	}

	private void btSin_Click(object sender, EventArgs e)
	{
	        str += "sin";
	        txtlcd.Text = str;
	}

	private void btPlus_Click(object sender, EventArgs e)
	{
	        str += "+";
	        txtlcd.Text = str;
	}

	private void btminus_Click(object sender, EventArgs e)
	{
	        str += "-";
	        txtlcd.Text = str;
	}

	private void btmul_Click(object sender, EventArgs e)
	{
	        str += "*";
	        txtlcd.Text = str;
	}

	private void button1_Click(object sender, EventArgs e)
	{
	        //절대로 띄어쓰기 없이 입력
	        //Radian단위로 계산
	        str = "20+4*2(5-1+(10-4/2))";		
	        txtlcd.Text = str;
	}

	private void button2_Click(object sender, EventArgs e)
	{
	        str = "sin30+cos30+2*20";
	        txtlcd.Text = str;
	}

	private void button3_Click(object sender, EventArgs e)
	{
	        str = "((32+4)-3)-(21-3*2)*(6/3)";
	        txtlcd.Text = str;
	}

        }
}
