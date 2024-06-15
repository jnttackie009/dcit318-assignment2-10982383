using System;

namespace InheritanceAndMethodOverlaoding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }
}