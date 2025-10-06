using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignFive
{
    internal struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Error: Width cannot be negative!");
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine("Error: Height cannot be negative!");
            }
        }
        public double Area
        {
            get{ return width * height;  }
        }
        public Rectangle(double width, double height)
        {
            this.width = 0;
            this.height = 0;
            Width = width;
            Height = height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Width: {Width}");
            Console.WriteLine($"Rectangle Height: {Height}");
            Console.WriteLine($"Rectangle Area: {Area}");
        }
    }
}
