using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSpring.net
{
    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine(this.Name+" 汪汪~~");
        }
    }
}
