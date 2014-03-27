using System;
namespace next
{
    class lab03
    {
        public class Circle
        {
            public int x, y;
            public double radius;
        }
        public static void Main(string [] args)
        {
            Circle c1, c2;
            string tempstr;

            c1 = new Circle();
            c2 = new Circle();

            Console.WriteLine("=== circle collision test ===");
            Console.Write("circle1 x? ");
            tempstr = Console.ReadLine();
            c1.x = Convert.ToInt32(tempstr);
            Console.Write("circle1 y? ");
            tempstr = Console.ReadLine();
            c1.y = Convert.ToInt32(tempstr);
            Console.Write("circle1 radius? ");
            tempstr = Console.ReadLine();
            c1.radius = Convert.ToInt32(tempstr);

            Console.WriteLine();

            Console.Write("circle2 x? ");
            tempstr = Console.ReadLine();
            c2.x = Convert.ToInt32(tempstr);
            Console.Write("circle2 y? ");
            tempstr = Console.ReadLine();
            c2.y = Convert.ToInt32(tempstr);
            Console.Write("circle2 radius? ");
            tempstr = Console.ReadLine();
            c2.radius = Convert.ToInt32(tempstr);

            double distance = Math.Sqrt(Math.Pow((c2.x - c1.x),2) + Math.Pow((c2.y - c1.y),2));

            Console.WriteLine(distance);

            if((c1.radius  + c2.radius) - distance >= 0)
            {
                Console.WriteLine("Circle A and B are crashes");
            }
            else
            {
                Console.WriteLine("Did not crach with the Circle A and B");
            }

        }
    }
}