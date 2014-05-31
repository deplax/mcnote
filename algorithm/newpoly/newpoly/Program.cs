// 다음 연산이 가능하도록 Polynomial class 를 작성하시오.
//   1. AddTerm(double coef, int exp);
//     (a) Term 을 modeling 하시오
//     (b) Polynomial 을 초기화 하시오
//   2. void Print();
//   3. x^2 - 2x + 1 을 modeling 하시오
//   4. 위의 결과를 출력하시오.
//   5. Polynomial 을 단순화 하시오.
//   6. 주어진 Polynomial 을 역순으로 정렬하시오.
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
            public Term prev;
        }
        class Polynomial
        {
            public Term first;
            public Polynomial()
            {
                first = null;
            }

            public void Simplify()
            {
                for(Term t = first; t != null; t = t.next)
                {
                    for(Term s = t.next; s != null; s = s.next)
                    {
                        if (t.exp == s.exp)
                        {
                            t.coef += s.coef;
                            DeleteTerm(s);
                            if(t.coef == 0)
                            {
                                DeleteTerm(t);
                            }
                        }
                    }
                }
            }

            public void AddTerm(double coef, int exp)
            {
                Term t = new Term();
                t.coef = coef;
                t.exp = exp;

                if (first == null)
                {
                    t.next = null;
                    t.prev = null;
                    first = t;
                    
                }
                else
                {
                    t.next = first;
                    t.next.prev = t;
                    first = t;
                }
            }
            public void DeleteTerm(Term s)
            {
                if (s.next == null)
                {
                    s.prev.next = null;
                }
                else if (s.prev == null)
                {
                    s.next.prev = null;
                    first = s.next;
                }
                else
                {
                    s.prev.next = s.next;
                    s.next.prev = s.prev;
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

            public void SwapNext(Term t)
            {
                double coef = t.coef;
                int exp = t.exp;
                t.coef = t.next.coef;
                t.exp = t.next.exp;
                t.next.coef = coef;
                t.next.exp = exp;
            }

            public void SortPoly()
            {
                int allCnt = 0;
                int cnt = 0;
                bool breakSw = false;

                while (true)
                {

                    for (Term t = first; t.next != null; t = t.next)
                    {

                        if (t.exp < t.next.exp)
                        {
                            SwapNext(t);
                        }

                        if (breakSw == true)
                        {
                            cnt--;
                            if (cnt == 0)
                            {
                                allCnt--;
                                cnt = allCnt;
                                break;
                            }
                        }
                        else
                        {
                            allCnt++;
                        }

                        if (t.next.next == null) //마지막 루프이면
                        {
                            cnt = allCnt;
                            breakSw = true;
                        }

                    }
                    if (allCnt == 0)
                        break;
                }
            }
        }
        static void Main()
        {
            Polynomial p = new Polynomial();
            p.AddTerm(-4, 5);
            p.AddTerm(3, 5);
            p.AddTerm(1, 2);
            p.AddTerm(-1, 1);
            p.AddTerm(-1, 1);
            p.AddTerm(1, 0);
            p.AddTerm(3, 2);
            p.AddTerm(5, 1);
            p.PrintPoly();

            p.Simplify();
            p.PrintPoly();

            p.SortPoly();
            p.PrintPoly();
        }
    }
}
