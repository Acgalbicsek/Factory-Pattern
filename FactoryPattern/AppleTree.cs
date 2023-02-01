using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class AppleTree : ITree
    {

        public void Type()
        {
            Console.WriteLine("You have an apple tree in your backyard!");
        }

    }
}
