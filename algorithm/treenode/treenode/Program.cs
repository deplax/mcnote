using System;

namespace treenode
{
<<<<<<< HEAD
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
	        else if (id < this.id)
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
		        left.Insert(s);
	        }
	        else if (s.id == id)
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
		        right.Insert(s);
	        }
	}

	public void Delete(int id)
	{
	        Student s = SearchStudent(id);
	        if(s.left == null && s.right == null )		//Leaf Node
	        {
		if (s.parent.left == s)
		        s.parent.left = null;
		else
		        s.parent.right = null;
	        }
	        else
	        {
		swapNode(s, SearchChangeNode(s));
		if (s.parent.left == s)
		        s.parent.left = null;
		else
		        s.parent.right = null;
	        }
	}
	public void swapNode(Student a, Student b)
	{
	        Student temp = new Student(0, null, null) ;
	        temp.left = a.left;
	        temp.right = a.right;
	        temp.parent = a.parent;
	        a.left = b.left;
	        a.right = b.right;
	        

	        if (a == b.parent)		        //인접노드일때
	        {
		a.parent = b;
		if (b.parent.id < b.id)
		{
		        b.right = a;
		        b.left = temp.left;
		}
		else
		{
		        b.left = a;
		        b.right = temp.right;
		}

	        }
	        else
	        {
		a.parent = b.parent;
		b.left = temp.left;
		b.right = temp.right;

		if (a.parent != null)
		{
		        if (a.parent.id < a.id)
			a.parent.right = a;
		}
	        }

	        b.parent = temp.parent;
	        
	        if (b.parent != null)		        //관련 노드들 정리;
	        {
		if (b.parent.id < b.id)
		        b.parent.right = b;
	        }

	}

	public Student SearchChangeNode(Student s)
	{
	        int cntLeft = 0;
	        int cntRight = 0;

	        Student sLeft = SearchLeftLeafNode(ref cntLeft, s.left);
	        Student sRight = SearchRightLeafNode(ref cntRight, s.right);

	        if (cntLeft >= cntRight)
		return sLeft;
	        else
		return sRight;  
	}

	public Student SearchLeftLeafNode(ref int cnt, Student s)
	{
	        if(s.right != null)
	        {
		cnt++;
		s = SearchLeftLeafNode(ref cnt, s.right);
	        }
 	        return s;
	}

	public Student SearchRightLeafNode(ref int cnt, Student s)
	{
	        if (s.left != null)
	        {
		cnt++;
		s = SearchRightLeafNode(ref cnt, s.left);
	        }
	        return s;
	}
        }

        class TreeNode
        {
	static void Main(string[] args)
	{
	        //Student s = new Student(10, "kim", "kim.jpg");
	        //s.Insert(new Student(3, "park", "park.jpg"));
	        //s.Insert(new Student(1, "lee", "lee.jpg"));
	        //s.Insert(new Student(14, "lee", "lee.jpg"));
	        //s.Insert(new Student(7, "lee", "lee.jpg"));
	        //s.Insert(new Student(7, "lee", "lee.jpg"));
	        //s.Insert(new Student(1243, "lee", "lee.jpg"));
	        //s.Insert(new Student(13, "lee", "lee.jpg"));

	        Student s = new Student(40, "40", "40.jpg");
	        s.Insert(new Student(30, "30", "30.jpg"));
	        s.Insert(new Student(50, "50", "50.jpg"));
	        s.Insert(new Student(20, "20", "20.jpg"));
	        s.Insert(new Student(35, "35", "35.jpg"));
	        s.Insert(new Student(45, "45", "45.jpg"));
	        s.Insert(new Student(60, "60", "60.jpg"));
	        s.Insert(new Student(10, "10", "10.jpg"));
	        s.Insert(new Student(25, "25", "25.jpg"));
	        s.Insert(new Student(32, "32", "32.jpg"));
	        s.Insert(new Student(37, "37", "37.jpg"));
	        s.Insert(new Student(42, "42", "42.jpg"));
	        s.Insert(new Student(47, "47", "47.jpg"));
	        s.Insert(new Student(55, "55", "55.jpg"));
	        s.Insert(new Student(70, "70", "70.jpg"));
	        s.Delete(60);


	        //s.SearchStudent(14).PrintSubtree(0);
	        s.PrintSubtree(0);
	}
        }
}
=======
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

            int leftCnt = 0;
            int rightCnt = 0;

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
                int leftId = s.DepthSearch(ref leftCnt, s.left, false);
                int rightId = s.DepthSearch(ref rightCnt, s.right, true);
                if (leftCnt >= rightCnt)
                {
                    Student t = SearchStudent(leftId);
                    t.parent.left = null;
                    //SwapNode(s, t);
                    s.id = t.id;
                    s.name = t.name;
                    s.picture = t.picture;
                    //t.parent.left = null;


                }
                else
                {
                    Student t = SearchStudent(rightId);
                    t.parent.right = null;
                    s.name = t.name;
                    s.picture = t.picture;
                    t.parent.right = null;
                }
                //가장 깊은 곳을 찾고
                //가장 깊은 곳의 가장 왼쪽꺼와 치환 후
                //치환된 리프 노드를 버림
            }
        }
        public int DepthSearch(ref int cnt, Student s, bool leftsw)
        {
            if(leftsw == true)
            {
                if (s.left == null)
                    return s.id;
                else
                {
                    cnt++;
                    s.id = s.DepthSearch(ref cnt, s.left, true);
                }
                    
            }
            else
            {
                if (s.right == null)
                    return s.id;
                else
                {
                    cnt++;
                    s.id = s.DepthSearch(ref cnt, s.right, false);
                }
            }
            return s.id;
        }
        public void SwapNode(Student a, Student b)
        {
            Student tempLeft, tempRight, tempParent;
            if (a.parent != null)
                if (a.parent.id > a.id)
                    a.parent.left = b;
                else
                    a.parent.right = b;

            if(a.left == b)
            {
                tempLeft = a.left;
                tempRight = a.right;
                tempParent = a.parent;
                a.left = b.left;
                a.right = b.right;
                a.parent = b;           //
                b.left = a;             //
                b.right = tempRight;
                b.parent = tempParent;
            }
            else if (a.right == b)
            {
                tempLeft = a.left;
                tempRight = a.right;
                tempParent = a.parent;
                a.left = b.left;
                a.right = b.right;
                a.parent = b;           //
                b.left = a.left;             //
                b.right = a;
                b.parent = tempParent;
            }
            else if (b.left == a)
            {
                tempLeft = b.left;
                tempRight = b.right;
                tempParent = b.parent;  
                b.left = a.left;
                b.right = a.right;
                b.parent = a;           //
                a.left = b;             //
                a.right = tempRight;
                a.parent = tempParent;
            }
            else if (b.right == a)
            {
                tempLeft = b.left;
                tempRight = b.right;
                tempParent = b.parent;  
                b.left = a.left;
                b.right = a.right;
                b.parent = a;           //
                a.left = tempLeft;             //
                a.right = b;
                a.parent = tempParent;
            }
            else
            {
                tempLeft = a.left;
                tempRight = a.right;
                tempParent = a.parent;

                
                

                a.left = b.left;
                a.right = b.right;
                a.parent = b.parent;
                b.left = tempLeft;
                b.right = tempRight;
                b.parent = tempParent;
            }
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

            s.Delete(10);

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
>>>>>>> ca16a452c3d5fc850fd6d4ff744e8ec6e36c2088
