using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSeven.interfaces
{
    internal interface IRectangle : Ishape
    {
        double Width { get; }
        double Height { get; }
    }
}
