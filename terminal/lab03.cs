using System;
namespace next{
	public class Student {
		public String name;
		public int kor;
		public int math;
		public double avg;
	}

	class Lab3{
		public static void Main(String [] args){
			Student s1 = new Student();
			s1.name = "Lim";
			s1.kor = 80;
			s1.math = 90;
			s1.avg = (double)(s1.kor + s1.math) / 2;
			
			Student s2 = new Student();
			s2.name = "Kim";
			s2.kor = 87;
			s2.math = 90;
			s2.avg = (double)(s2.kor + s2.math) / 2;

			double tavg = (s1.avg + s2.avg) / 2;

			Console.WriteLine ("'");
			Console.WriteLine ("'{0}' average is {1}", s1.name, s1.avg);
			Console.WriteLine ("'{0}' average is {1}", s2.name, s2.avg);
			Console.WriteLine ("'{0}' and '{1}' total average is {2}", s1.name, s2.name, tavg);
		}
	}
}
