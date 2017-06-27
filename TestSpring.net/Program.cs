using Spring.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSpring.net
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建Spring.Net容器
            IApplicationContext ctx = Spring.Context.Support.ContextRegistry.GetContext();

            Animal obj = CRM11.Utility.DI.GetObject<Animal>("myAnimal");

            Animal obj2 = ctx.GetObject("myAnimal") as Animal;

            obj.Bark();
            Console.Read();
        }
    }
}
