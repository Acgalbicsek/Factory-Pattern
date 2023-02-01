using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class GreenHouse
    {
        public static ITree GetTree(string fruitType) 
        {
            switch (fruitType)
            {
                case "apple":
                    return new AppleTree();
                case "orange":
                    return new OrangeTree();
                default:
                    return new AppleTree();
                  
            }
        }
    }
}
