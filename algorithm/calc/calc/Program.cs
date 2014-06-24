using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
        class Stack
        {
	protected int top = -1;
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
	        if (top > 0)
		top--;
	        return op[top + 1];
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
	        if (top > 0)
		top--;
	        return val[top + 1];
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
//	        Console.WriteLine("Error: Node Call");
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
	public char op;
	public Node left, right;
	public OpNode(char op)
	{
	        this.op = op;
	        left = null;
	        right = null;
	}
	public OpNode() { }
	public override double cal()
	{
	        double lv = left.cal();
	        double rv = right.cal();
	        switch (op)
	        {
		case '*':
		        return lv * rv;
		case '+':
		        return lv + rv;
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
	static void MakeTree(String input)
	{

	}
	
	static void Main(string[] args)
	{
	        OpStack opStack = new OpStack();
	        ValStack valStack = new ValStack();

	        ValNode a = new ValNode(4);
	        ValNode b = new ValNode(2);
	        OpNode c = new OpNode('+');

	        

	        MakeTree("4, 2, +");

	        valStack.Push(a);
	        valStack.Push(b);
	        opStack.Push(c);

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
