using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            Bicycle bicycle = new();

            car.Move();
            bicycle.Move();
        }
    }
}