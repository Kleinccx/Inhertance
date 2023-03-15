using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conShape
{
    internal class Rectangle : clsShape
    {
        private double length;
        private double width;

        public Rectangle(string name, int sides, double length, double width)
        {
            base.Name = name;
           base.Sides = sides;
            this.Length = length;
            this.Width = width;

        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override string ToString()
        {

            return "\nName: " + this.Name +
                "\nSide: " + this.Sides +
                "\nlength: " + this.length +
                 "\nWidth: " + this.width +
                  "\nArea: " + this.ComputeArea() +
            "\nPerimeter: " + this.ComputePerimeter();
        }
        public override double ComputeArea()
        {
            return this.length * this.width;
        }
        public override double ComputePerimeter()
        {
            return this.length * 2 + this.width *2;
        }
    }
}
