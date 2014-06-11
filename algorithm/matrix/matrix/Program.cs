using System;

namespace matrix
{
    class Program
    {
        class Elem
        {
            public int rid, cid;
            public double val;
            public Elem(int rid, int cid, double val)
            {
                this.rid = rid;
                this.cid = cid;
                this.val = val;
            }
        }

        class SparseMatrix
        {
            public int rows, cols;
            Elem[] buffer = new Elem[1];
            int bufptr = 0;

            public SparseMatrix(int rows, int cols)
            {
                this.rows = rows;
                this.cols = cols;
            }
            public void AddElem(int rid, int cid, double val)
            {
                Elem e = new Elem(rid, cid, val);
                if(bufptr >= buffer.Length)
                {
                    Console.WriteLine("buffer doubled {0}", buffer.Length);
                    Elem[] tmp = new Elem[bufptr * 2];
                    for(int i = 0; i < buffer.Length; i++)
                    {
                        tmp[i] = buffer[i];
                    }
                    buffer = tmp;
                }
                buffer[bufptr] = e;
                bufptr++;
            }
            public void Print()
            {
                for(int i = 0; i <bufptr; i++)
                {
                    int rid = buffer[i].rid;
                    int cid = buffer[i].cid;
                    double val = buffer[i].val;
                    Console.WriteLine("{0}, {1}, {2}", rid, cid, val);
                }
            }
            public void PrintMatrix()
            {
                //double[,] m = new double[6, 6];
                int p = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (p < bufptr)
                        {
                            int rid = buffer[p].rid;
                            int cid = buffer[p].cid;
                            double val = buffer[p].val;
                            if (rid == i && cid == j)
                            {
                                Console.Write(" {0} ", val);
                                p++;
                            }
                            else
                            {
                                Console.Write(" 0 ");
                            }
                        }
                        else
                        {
                            Console.Write(" 0 ");
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
            public void Sort()
            {
                Elem[] tmp = new Elem[bufptr];

                for (int i = 0; i < bufptr; i++ )
                {
                    tmp[i] = buffer[i];
                }

                    Array.Sort(tmp, delegate(Elem x, Elem y)
                    {
                        if (x.rid < y.rid)
                        {
                            return -1;
                        }
                        else if (x.rid > y.rid)
                        {
                            return 1;
                        }
                        else
                        {
                            if (x.cid < y.cid)
                            {
                                return -1;
                            }
                            else if (x.cid > y.cid)
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    });
                for(int i = 0; i <bufptr; i++)
                {
                    buffer[i] = tmp[i];
                }
            }

            public SparseMatrix() { }
            public void TransPose()
            {
                for(int i = 0; i < bufptr; i++)
                {
                    int rid = buffer[i].rid;
                    int cid = buffer[i].cid;
                    buffer[i].rid = cid;
                    buffer[i].cid = rid;
                }
                Sort();
            }

            public SparseMatrix Addition(SparseMatrix that)
            {
                SparseMatrix res = new SparseMatrix();
                res.rows = rows;
                res.cols = cols;
                
                int left = 0, right = 0;
                for (; left < bufptr && right < that.bufptr; )
                {


                    Elem a = buffer[left], b = that.buffer[right];
                    if (a.rid < b.rid)
                    {
                        res.AddElem(a.rid, a.cid, a.val);
                        left++;

                    }
                    else if (a.rid > b.rid)
                    {
                        res.AddElem(b.rid, b.cid, b.val);
                        right++;
                    }
                    else
                    {
                        if (a.cid < b.cid)
                        {
                            res.AddElem(a.rid, a.cid, a.val);
                            left++;
                        }
                        else if (a.cid > b.cid)
                        {
                            res.AddElem(b.rid, b.cid, b.val);
                            right++;
                        }
                        else
                        {
                            res.AddElem(a.rid, a.cid, a.val + b.val);
                            left++;
                            right++;
                        }
                    }
                }
                for(; right < that.bufptr; right++)
                {
                    Elem e = that.buffer[right];
                    res.AddElem(e.rid, e.cid, e.val);
                }
                for(; left < bufptr; left++)
                {
                    Elem e = buffer[left];
                    res.AddElem(e.rid, e.cid, e.val);
                }
                return res;
            }

            
        }
        static void Main()
        {
            SparseMatrix m = new SparseMatrix(6, 6);
            m.AddElem(1, 1, 11);

            m.AddElem(0, 0, 15.2433);
            m.AddElem(0, 3, 20);
            m.AddElem(0, 5, -15);

            m.AddElem(1, 2, 3);
            m.AddElem(2, 3, -6);
            m.AddElem(4, 0, 91);
            m.AddElem(5, 2, 28);
            m.AddElem(5, 3, 62);

            m.Sort();
            m.PrintMatrix();
            m.Addition(m).PrintMatrix();

        }
    }
}
