using System;

namespace InheritanceAndMethodOverlaoding
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}