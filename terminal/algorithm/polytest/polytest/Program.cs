/*
using System;
namespace cookie
{
        class P
        {
	
	class Term
	{
	        public double coef;
	        public int exp;
	        //public int length = 0;
	        public Term next;
	}

	class Polynomial
	{
	        public Term first;
	        public Polynomial()
	        {
		first = null;
	        }
	        public void AddTerm(double coef, int exp)
	        {
		Term t = new Term();
		t.coef = coef;
		t.exp = exp;
		//t.length++;

		if (first == null)
		{
		        first = t;
		        t.next = null;
		}
		else
		{
		        t.next = first;
		        first = t;
		}
	        }
	        public void PrintPoly()
	        {
		Console.Write("PrintPoly : ");
		for (Term t = first; t != null; t = t.next)
		{
		        if (t == first)
		        {
			Console.Write("{0}x^{1}", t.coef, t.exp);
		        }
		        else
		        {
			Console.Write(" + {0}x^{1}", t.coef, t.exp);
		        }
		}
		Console.WriteLine();
	        }
	        public void Simplyfy()
	        {
		Polynomial resPoly = new Polynomial();
		for (Term t = first; t != null; t = t.next)
		{
		        for (Term s = t; s.next != null; s = s.next)
		        {
			if (t.exp == s.next.exp)
			{
			        t.coef += s.next.coef;
			        //t.length--;
			        if (s.next.next != null)
			        {
				t.next.next = t.next.next.next;
			        }
			        else
			        {
				t.next = null;
				break;
			        }

			}

		        }
		}
	        }
	        
	        //public void PrintDESC()
	        //{
	        //        Polynomial descPoly = new Polynomial();

	        //        int max = 0;
	        //        Console.Write("PrintPolyDESC : ");
	        //        for (Term t = first; t != null; t = t.next)
	        //        {
	        //	if (max < t.exp)
	        //	        max = t.exp;
	        //        }
		
	        //        for (Term t = first; t != null; t = t.next)
	        //        {
	        //	if (max  t.exp)
	        //	        max = t.exp;
	        //        }

	        //}

	        public void Sort()
	        {
		Polynomial sortedPoly = new Polynomial();
		while (true)
		{
		        for (Term t = first; t.next != null; t = t.next)
		        {
			if (t.exp < t.next.exp)
			{
			        Term temp = null;
			        temp = t;
			        t = t.next;
			        t.next = temp;
			}
		        }
		}
	        }
	}

	public static void Main()
	{
	        Polynomial p = new Polynomial();

	        p.AddTerm(1, 2);
	        p.AddTerm(2, 3);
	        p.AddTerm(2, 2);
	        p.AddTerm(2, 3);
	        //Console.WriteLine(p.first.next.next);
	        //Console.WriteLine(p.first.next);
	        //Console.WriteLine(p.first.coef);
	       // Console.WriteLine(p.first.exp);
	        Console.WriteLine(p);
	        //p.AddTerm(-1, 1);
	        //p.AddTerm(-1, 1);
	        //p.AddTerm(1, 0);
	        p.PrintPoly();
	        p.Simplyfy();//.PrintPoly();
	        p.PrintPoly();
	        p.PrintPoly();
	        

	        //Console.WriteLine("asdf");

	}
        }
}
*/

using System;

namespace N
{
        class M
        {
	class Term
	{
	        public double coef;
	        public int exp;
	        public Term next;
	}
	class Polynomial
	{
	        public Term first;
	        public Polynomial()
	        {
		first = null;
	        }
	        public Polynomial Simplify()
	        {
		Polynomial resPoly = new Polynomial();
		for (Term t = first; t != null; t = t.next)
		{
		        double coef = t.coef;
		        int exp = t.exp;
		        for (Term s = t.next; s != null; s = s.next)
		        {
			if (exp == s.exp)
			{
			        coef += s.coef;
			        s.coef = 0;
			}
		        }
		        resPoly.AddTerm(coef, exp);
		}

		for (Term t = resPoly.first; t.next != null; t = t.next)
		{
		        if (t.next.coef == 0)
		        {
			t.next = t.next.next;
		        }
		}
		return resPoly;
	        }
	        public void AddTerm(double coef, int exp)
	        {
		// term 을 만들고
		Term t = new Term();
		t.coef = coef;
		t.exp = exp;
		// 어딘가 넣어야
		if (first == null)
		{
		        first = t;
		        t.next = null;
		}
		else
		{
		        t.next = first;
		        first = t;
		}
	        }
	        public void PrintPoly()
	        {
		Console.WriteLine("PrintPoly: asdf");
		for (Term t = first; t != null; t = t.next)
		{
		        Console.Write("+ ({0},{1})", t.coef, t.exp);
		}
		Console.WriteLine("");
	        }
	}
	static void Main()
	{
	        Polynomial p = new Polynomial();
	        p.AddTerm(1, 2);
	        p.AddTerm(-1, 1);
	        p.AddTerm(-1, 1);
	        p.AddTerm(1, 0);
	        p.PrintPoly();
	        Console.WriteLine("asdf");
	        p.Simplify().PrintPoly();
	}
        }
}

