using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSix
{
    internal class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("message from DerivedClass2");
        }
    }
}
