using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
        class Stack
        {
	public int top = -1;
        }
        class OpStack : Stack
        {
	OpNode[] op;
	public OpStack()
	{
	        op = new OpNode[10];
	}
	public void Push(OpNode item)
	{
	        top++;
	        if (top < op.Length)	        //길이 정확히 얼만지 확인필요
		op[top] = item;

	}
	public OpNode Pop()
	{
	        if (top > -1)
	        {
		top--;
		return op[top + 1];
	        }
	        else
	        {
		return null;
	        }
	        
	}
        }
        class ValStack : Stack
        {
	ValNode[] val;
	public ValStack()
	{
	        val = new ValNode[10];
	}
	public void Push(ValNode item)
	{
	        top++;
	        if (top < val.Length)	        //길이 정확히 얼만지 확인필요
		val[top] = item;
	}
	public ValNode Pop()
	{
	        if (top > -1)
		top--;
	        return val[top + 1];
	}
	public ValNode Peek()
	{
	        return val[top];
	}
        }
        class StringStack : Stack
        {
	string[] st;
	public StringStack()
	{
	        st = new string[20];
	}
	public void Push(string item)
	{
	        top++;
	        if (top < st.Length)	        //길이 정확히 얼만지 확인필요
		st[top] = item;
	}
	public string Pop()
	{
	        if (top > -1)
		top--;
	        return st[top + 1];
	}
	public string Peek()
	{
	        return st[top];
	}
        }


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
        class Program
        {
	static OpNode MakeTree2(String input)
	{
	        OpStack opStack = new OpStack();
	        ValStack valStack = new ValStack();
	        double temp;
	        bool pairsw = false;

	        string[] c = input.Split(' ');
	        for(int i = 0; i < c.Length; i++)
	        {
		//if(char.IsNumber(Convert.ToChar(c[i])))
		if(double.TryParse(c[i], out temp))
		{
		        ValNode val = new ValNode(Convert.ToDouble(c[i]));
		        valStack.Push(val);
		}
		else								//문자라면
		{
		        /*
		        OpNode op = new OpNode(Convert.ToString(c[i]));
		        ValNode[] a = new ValNode[2]; 
		        int cnt = 0;
		        for (int j = 0; j < 2; j++ )
			if (valStack.top > -1)
			{	        
			        a[j] = valStack.Pop();
			        cnt++;
			}
		        if(cnt == 1)
		        {
			op.right = a[0];
			op.left = opStack.Pop();
		        }
		        else if(cnt == 2)
		        {
			op.right = a[0];
			op.left = a[1];
		        }
		        else if(cnt == 0)
		        {
			op.right = opStack.Pop();
			op.left = opStack.Pop();
		        }
		        opStack.Push(op);
		         */

		        //value 스텍이 비어있지 않은데
		        OpNode op = new OpNode(Convert.ToString(c[i]));

		        
		        if (i != 0 && double.TryParse(c[i-1], out temp) && double.TryParse(c[i-2], out temp))
		        {
			//숫자가 연속으로 들어왔다면
			op.right = valStack.Pop();
			op.left = valStack.Pop();
		        }
		        else if(valStack.top != -1)
		        {
			//스택이 비어있지 않다면
			op.left = valStack.Pop();
			op.right = opStack.Pop();
		        }
		        else
		        {
			op.right = opStack.Pop();
			op.left = opStack.Pop();
		        }
		        opStack.Push(op);
		}	  
	        }
	        return opStack.Pop();
	}

	static string Infix_Postfix(string str)
	{
	        string[] s = str.Split(' ');
	        string postfix = "";
	        double temp;
	        bool sw = true;
	        StringStack strStack = new StringStack();
	        for (int i = 0; i < s.Length; i++ )
	        {
		if(double.TryParse(s[i], out temp))		//숫자라면
		{
		        postfix = postfix + " " + s[i];
		}
		else					//연산자라면
		{
		        if(s[i] == "(")
		        {
			strStack.Push(s[i]);
		        }
		        else if (s[i] == ")")
		        {
			while (sw)
			{
			        string t = strStack.Pop();
			        if (t == "(")
			        {
				sw = false;
			        }
			        else
			        {
				postfix = postfix + " " + t;
			        }
			}
			sw = true;
		        }
		        else if(strStack.top == -1)			//스텍이 비었다면
		        {
			strStack.Push(s[i]);
		        }
		        else
		        {
			if(s[i] == "+" || s[i] == "-")		//연산자 우선순위가 낮다면
			{
			        string t = strStack.Peek();
			        if (t == "*" ||t == "/" || t == "sin")
			        {
				postfix = postfix + " " + strStack.Pop();
			        }
			}
			strStack.Push(s[i]);
		        }
		}
	        }
	        while (sw)
	        {
		if(strStack.top == -1)
		{
		        sw = false;
		}
		else
		{
		        postfix = postfix + " " + strStack.Pop();
		}
	        }

	        return postfix.Remove(0, 1);
	}

	class MakeTree
	{
	        OpNode[] opn;
	        bool search = true;		//가로 탐색여부
	        double temp;
	        string[] s;

	        int start;			//가로시작
	        int end;			//가로끝
	        int current;			//현재위치

	        int cnt = 0;			//사용검사 카운터
	        int level = -1;		//연산자 우선순위

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
		        if (opn[i] != null)					        //피연산자이면
		        {
			opn[current].left = opn[i];
			s[i] = null;
			opn[i] = null;
			break;
		        }
		        else if (double.TryParse(s[i], out temp))		        //숫자이면
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
		        if (opn[i] != null)					        //피연산자이면
		        {
			opn[current].right = opn[i];
			s[i] = null;
			opn[i] = null;

			break;
		        }
		        else if (double.TryParse(s[i], out temp))		        //숫자이면
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
	static void Main(string[] args)
	{
	        string str = "32 + ( 5 * 3 - 5 + 2 + 43 + 33 / 20 * ( ( 40 * 2 ) + 43 ) - 3 )";
	        str = "sin ( 30 * 3 ) + 1";
	        MakeTree mt = new MakeTree(str);
	        OpNode op = mt.Making();
	        Console.WriteLine("{0}", op.cal());

	        //OpNode tt = MT("7 - ( 2 * 3 + 5 ) * ( 8 - 4 / 2 )");

	        //Node[] x = new Node[10];
	        //x[1] = new OpNode("+");

	        //string str = Infix_Postfix("7 - ( 2 * 3 + 5 ) * ( 8 - 4 / 2 )");
	        //OpNode test = MakeTree(str);
	        //Console.WriteLine("{0}", test.cal());

	       //alStack.Push(a);
	        //valStack.Push(b);
	        //opStack.Push(c);

	        //OpNode mul = new OpNode('*');
	        //mul.left = new ValNode(3);
	        //mul.right = new ValNode(2);

	        //OpNode plus = new OpNode('+');
	        //plus.left = mul;
	        //plus.right = new ValNode(4);

	        //plus.Print();

	        //Console.WriteLine("{0}", plus.cal());
	        //Console.WriteLine("{0}", double.Parse("36.4"));


	        //Infix 를 Prefix 로 바꾸는게 필요하겠네요. 근데 이건 당장 안해도 되요

	        //Infix로 들어온다고 가정하죠

	        //스택을 두개 만들어요 하나는 연산자용, 하나는 숫자용
	        //숫자면 PUSH 하다가
	        //연산자를 만나면 모두 POP해줘요.
	        //POP이 하나밖에 없으면 연산자를 끌어와요
	        //정리되면 연산자를 스텍에 PUSH해요


	}
        }
}
