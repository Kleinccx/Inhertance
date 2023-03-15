using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conShape
{
    internal class clsSquare : clsShape
    {

      
        private double side1;

        public double Side1 { get => side1; set => side1 = value; }

        public clsSquare()
        {

        }
        public clsSquare(String Name, int Sides, double  Side1)
        {
            this.Name = Name;
            this.Sides = Sides;
            this.Side1 = Side1;
          

        }

        public override string ToString()
        {
            return "\nName: " + this.Name +
                "\nSide" + this.Sides +
                "\nlength of one side: " + this.side1 +
                 "\nArea: " + this.ComputeArea() +
                 "\nPerimeter: " + this.ComputePerimeter();
        }
        public override double ComputeArea()
        {
            return Math.Pow(this.side1, 2);
        }
        public override double ComputePerimeter()
        {
            return this.side1 * 4;
        }
       


    }
}