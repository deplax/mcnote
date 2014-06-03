using System;

namespace treenode
{
    class Student
    {
        public int id;
        public string name;
        public string picture;

        public Student left, right, parent;

        public Student(int id, string name, string picture)
        {
            this.id = id;
            this.name = name;
            this.picture = picture;
            left = null;
            right = null;
            parent = null;
        }

        public void PrintSubtree(int level)
        {
            if (left != null)
            {
                left.PrintSubtree(level + 1);
            }
            for (int i = 0; i < level; i++)
            {
                Console.Write("  ");
            }
                Console.WriteLine("{0} {1} {2}", id, name, picture);
            
            if (right != null)
            {
                right.PrintSubtree(level + 1);
            }
        }
        public Student SearchStudent(int id)
        {
            if (id == this.id)
            {

                return this;
            }
            else if ( id < this.id)
            //else if (left != null && id < this.id)
            {
                if (left == null)
                    return null;
                return left.SearchStudent(id);
            }
            else if (id > this.id)
            {
                if (right == null)
                    return null;
                else
                    return right.SearchStudent(id);
            }
            else
            {
                return null;
            }
        }
        public void Insert(Student s)
        {

            if (s.id < id)
            {
                if (left == null)
                {
                    left = s;
                    s.parent = this;
                }
                else
                {
                    left.Insert(s);
                }
            }
            else if(s.id == id)
            {
                Console.WriteLine("Error : duplicate id {0}", s.id);
            }
            else
            {
                if (right == null)
                {
                    right = s;
                    s.parent = this;
                }
                else
                {
                    right.Insert(s);
                }
            }


        }
        public void Delete(int id)
        {
            Student s = SearchStudent(id);

            int rightId = 0;
            int leftId = 0;

            if ((s.right == null) || (s.left == null))      //Leaf Node
            {
                if(s.right == null)
                {
                    s.parent.right = null;
                }
                else
                {
                    s.parent.left = null;
                }
            }
            else
            {
                if ((s.DepthSearch(ref leftId, 0, s.right, true)) >= (s.DepthSearch(ref rightId, 0, s.left, false)))
                {
                    Student t = SearchStudent(leftId);
                    s.name = t.name;s
                    s.pic
                }
                //가장 깊은 곳을 찾고
                //가장 깊은 곳의 가장 왼쪽꺼와 치환 후
                //치환된 리프 노드를 버림
            }
        }
        public int DepthSearch(ref int id, int cnt, Student s, bool leftsw)
        {
            if(leftsw == true)
            {
                if (s.left == null)
                    return cnt;
                else
                {
                    cnt++;
                    s.DepthSearch(0, cnt, s.left, true);
                }
                    
            }
            else
            {
                if (s.right == null)
                    return cnt;
                else
                {
                    cnt++;
                    s.DepthSearch(cnt, s.right, false);
                }
            }
            return -1;
        }
    }

    class TreeNode 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Student s = new Student(10, "kim", "kim.jpg");
            s.Insert(new Student(3, "park", "park.jpg"));
            s.Insert(new Student(1, "lee", "lee.jpg"));
            s.Insert(new Student(14, "lee", "lee.jpg"));
            //s.Insert(new Student(7, "lee", "lee.jpg"));
            s.Insert(new Student(7, "lee", "lee.jpg"));
            s.Insert(new Student(1243, "lee", "lee.jpg"));
            s.Insert(new Student(13, "lee", "lee.jpg"));

            s.Delete(7);

            //s.SearchStudent(14).PrintSubtree(0);
            //Random r = new Random();
            

            //for (int i = 0; i < 100; i++ )
            //{
            //    s.Insert(new Student(r.Next(0, 1000), "lee", "lee.jpg"));
            //}
                //Student s2 = new Student(14, "lee", "lee.jpg");
                //Student s3 = new Student(1, "asef", "asdf.jpg");
                //s1.left = s3;
                //s.left = s1;
                //s.right = s2;
            s.PrintSubtree(0);
        }
    }
}
