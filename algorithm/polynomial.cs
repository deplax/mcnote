using System;
namespace cookie
{
	class P
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
			public void AddTerm(double coef, int exp)
			{
				Term t = new Term();
				t.coef = coef;
				t.exp = exp;

				if(first == null)
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
				Console.WriteLine("PrintPoly : ");
				for (Term t = first; t != null; t = t.next)
				{
					Console.Write(" + ({0},{1})", t.coef, t.exp);
				}
				Console.WriteLine();
			}
			public Polynomial Simplyfy()
			{
				Polynomial resPoly = new Polynomial();
				for (Term t = first; t !=null; t = t.next)
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
				return resPoly;
			}
		}

		public static void Main()
		{
			Polynomial p = new Polynomial();
			
			p.AddTerm(1, 2);
			p.AddTerm(-1, 1);
			p.AddTerm(-1, 1);
			p.AddTerm(1, 0);
			p.Simplyfy().PrintPoly();
			p.PrintPoly();

			Console.WriteLine("asdf");

		}
	}
}

