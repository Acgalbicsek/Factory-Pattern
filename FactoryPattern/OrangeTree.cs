using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class OrangeTree : ITree
    {
 
        public void Type()
        {
            Console.WriteLine("You have an orange tree in your backyard!");
        }

    }
}
