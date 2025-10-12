using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace assignSix
{
    internal class rectangle
    {
        private int weight;
        private int height;

        public rectangle()
        {
            weight = 0;
            height = 0;
            Console.WriteLine(weight + "\t" + height);
        }
        public rectangle(int a, int b)
        {
            weight = a;
            height = b;
            Console.WriteLine(weight + "\t" + height);
        }
        public rectangle(int a)
        {
            weight = a;
            height = a;
            Console.WriteLine(weight + "\t" + height);
        }
    }
}
