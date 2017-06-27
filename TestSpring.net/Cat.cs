using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSpring.net
{
    public class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine(this.Name+" 瞄瞄~~");
        }
    }
}
