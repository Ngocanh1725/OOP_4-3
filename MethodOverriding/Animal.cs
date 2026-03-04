using System;

namespace ConsoleApp7
{
    internal class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Động vật phát ra tiếng kêu");
        }
    }

    internal class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chó: Gâu");
        }
    }

    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Mèo: Meo");
        }
    }

    internal class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bò: Ụm bò");
        }
    }
}