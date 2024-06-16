using System;

namespace AbstractClassAndMethod
{
    class Circle : Shape
    {
        double radius { get; set;}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

    }
}