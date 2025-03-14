﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3_PROG
{
    class Rectangle : Shape 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}

