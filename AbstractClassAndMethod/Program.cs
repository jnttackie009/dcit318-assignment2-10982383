using System;

namespace AbstractClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(10);
            Console.WriteLine($"The circle's area is: {circle.GetArea()}");

            Rectangle rectangle = new(6, 8);
            Console.WriteLine($"The rectangle's area is: {rectangle.GetArea()}");
        }
    }
}