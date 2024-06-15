using System;

namespace InheritanceAndMethodOverlaoding
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}