using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conShape
{
    internal class clsShape
    {
        private string name;
        private int sides;


        public clsShape()
        {

        }
        public clsShape(String n, int sides)
        {
            this.name = n;
            this.sides = sides;

        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }

        public  override string ToString()
        {
            return "\nName: " + this.Name +
                "\nSide: " + this.sides;
        }
        public  virtual double ComputeArea()
        {
            return 0.0;
        }
        public virtual double ComputePerimeter()
        {
            return 0.0;
            
        }

    }
}