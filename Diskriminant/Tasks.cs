using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Quadratic
{
    public struct Tasks
    {
        
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Tasks(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
