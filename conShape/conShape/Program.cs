﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conShape
{
    internal class Program
    {
        static void Main(string[] args)
        {

           clsShape shape1 = new clsShape();
            shape1.Name = "Shape 1";
            shape1.Sides = 0;
            Console.WriteLine(shape1);

            clsShape shape2 = new clsShape("shape 2", 0);
            Console.WriteLine(shape2);

            clsSquare sq = new clsSquare("Square", 4, 2);
            Console.WriteLine(sq);


            Rectangle rec = new Rectangle("Rectangle",4,3,5);
            Console.WriteLine(rec);







        }
    }
}
