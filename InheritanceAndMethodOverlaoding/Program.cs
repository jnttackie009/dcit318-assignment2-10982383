using System;

namespace InheritanceAndMethodOverlaoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the above created class
            Animal animal = new();
            Dog dog = new();
            Cat cat = new();

            //Call method for each instance
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}

