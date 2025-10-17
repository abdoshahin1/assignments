using assignSeven.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSeven
{
    internal class circle : Icircle
    {
        public double r {  get; set; }
        public circle(double radius)
        {
            r = radius;
        }
        public double area { get { return Math.PI * r * r; } }
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {r}");
            Console.WriteLine($"Area: {area:F2}\n");
        }
    }
}
