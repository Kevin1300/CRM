using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSpring.net
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Bark();
    }
}
