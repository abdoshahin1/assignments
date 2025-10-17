using assignSeven.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSeven
{
    internal class rectangle : IRectangle
    {
        public double Width { get;  set; }
        public double Height { get;  set; }

        public rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double area { get { return Width * Height; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {area:F2}\n");
        }
    }
}
