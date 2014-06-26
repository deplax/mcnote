using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGUI
{
        class Node
        {
	public virtual double cal()
	{
	        return 0;
	}
	public virtual void Print()
	{
	        Console.WriteLine("Node.Print()");
	}
        }
        class ValNode : Node
        {
	public double val;
	public ValNode(double val)
	{
	        this.val = val;
	}
	public ValNode() { }
	public override double cal()
	{
	        return val;
	}
	public override void Print()
	{
	        Console.WriteLine("{0}", val);
	}
        }
        class OpNode : Node
        {
	public string op;
	public Node left, right;
	public OpNode(string op)
	{
	        this.op = op;
	        left = null;
	        right = null;
	}
	public OpNode() { }
	public override double cal()
	{
	        double lv;
	        double rv;
	        if (left != null)
		lv = left.cal();
	        else
		lv = 0;
	        if (right != null)
		rv = right.cal();
	        else
		rv = 0;
	        switch (op)
	        {
		case "*":
		        return lv * rv;
		case "+":
		        return lv + rv;
		case "/":
		        return lv / rv;
		case "-":
		        return lv - rv;
		case "sin":
		        return Math.Sin(Math.PI * rv / 180);
		case "cos":
		        return Math.Cos(Math.PI * rv / 180);
		case "tan":
		        return Math.Tan(Math.PI * rv / 180);
		default:
		        Console.WriteLine("Error op");
		        return 0;
	        }
	}
	public override void Print()
	{
	        Console.WriteLine("{0}", op);
	        if (left != null)
	        {
		left.Print();
	        }
	        if (right != null)
	        {
		right.Print();
	        }
	}
        }
        class MakeTree
        {
	OpNode[] opn;
	bool search = true;		//가로 탐색여부
	double temp;
	string[] s;

	int start;				//가로시작
	int end;				//가로끝
	int current;			//현재위치

	int cnt = 0;			//사용검사 카운터
	int level = -1;			//연산자 우선순위

	public MakeTree(string str)
	{
	        s = str.Split(' ');
	        opn = new OpNode[s.Length];

	        start = 0;
	        end = s.Length;
	}

	void SearchLeft()
	{
	        for (int i = current - 1; i > start; i--)				        //왼방향 탐색
	        {
		if (opn[i] != null)						        //피연산자이면
		{
		        opn[current].left = opn[i];
		        s[i] = null;
		        opn[i] = null;
		        break;
		}
		else if (double.TryParse(s[i], out temp))			        //숫자이면
		{
		        opn[current].left = new ValNode(Convert.ToDouble(s[i]));
		        s[i] = null;
		        break;
		}
	        }
	}

	void SearchRight()
	{
	        for (int i = current + 1; i < end; i++)				        //오른방향 탐색
	        {
		if (opn[i] != null)						        //피연산자이면
		{
		        opn[current].right = opn[i];
		        s[i] = null;
		        opn[i] = null;

		        break;
		}
		else if (double.TryParse(s[i], out temp))			        //숫자이면
		{
		        opn[current].right = new ValNode(Convert.ToDouble(s[i]));
		        s[i] = null;

		        break;
		}
	        }
	}

	public OpNode Making()
	{
	        while (true)
	        {
		//괄호찾기 스위치
		if (search)
		{
		        search = false;
		        start = -1;
		        end = s.Length;
		        for (int i = 0; i < s.Length; i++)
		        {
			if (s[i] == "(")
			{
			        start = i;
			}
			else if (s[i] == ")")
			{
			        end = i;
			        break;
			}
		        }
		}
		else
		{
		        for (current = start + 1; current < end; current++)
		        {
			if ((s[current] == "sin" || s[current] == "cos" || s[current] == "tan") && opn[current] == null && level == -1)
			{
			        opn[current] = new OpNode(s[current]);
			        s[current] = null;

			        SearchRight();
			}
			else if ((s[current] == "*" || s[current] == "/") && opn[current] == null && level == 0)    //연산자이고 아직 사용한적이 없을 때
			{
			        opn[current] = new OpNode(s[current]);
			        s[current] = null;

			        SearchLeft();
			        SearchRight();
			}
			else if ((s[current] == "+" || s[current] == "-") && opn[current] == null && level == 1)
			{
			        opn[current] = new OpNode(s[current]);
			        s[current] = null;

			        SearchLeft();
			        SearchRight();
			}
		        }

		        level++;

		        for (int i = start + 1; i < end; i++)
		        {
			if (s[i] == null)
			        cnt++;
		        }

		        if (cnt == end - start - 1)
		        {
			if (cnt == s.Length)
			{
			        break;
			}
			search = true;
			s[start] = null;
			s[end] = null;
			level = -1;
		        }
		        cnt = 0;
		}
	        }
	        for (int i = 0; i < s.Length; i++)
	        {
		if (opn[i] != null)
		        return opn[i];
	        }
	        return null;
	}
        }
}
