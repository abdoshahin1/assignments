using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSix
{
    internal class complex
    {
        private int real;
        private int img;

        public override string ToString()
        {
            return real + " + " + img + "i";
        }
        public complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public static complex operator +(complex a, complex b)
        {
            complex resutl = new complex(((a?.real ?? 0) + (b?.real ?? 0)), ((a?.img ?? 0) + (b?.img ?? 0)));
            return resutl;
        }
        public static complex operator -(complex a, complex b)
        {
            complex resutl = new complex(((a?.real ?? 0) - (b?.real ?? 0)), ((a?.img ?? 0) - (b?.img ?? 0)));
            return resutl;
        }
    }
}
