using System;

namespace skit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rect1 = new Rectangle(5, 10);
            Console.WriteLine("Area: " + rect1.Area);
            Console.WriteLine("Omkrets: " + rect1.Circumferance);

            Triangle triangle1 = new Triangle(5, 10);
            Console.WriteLine("Area: " + triangle1.Area);
            Console.WriteLine("Omkrets: " + triangle1.Circumferance);
        }
    }
}
