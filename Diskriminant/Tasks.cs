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
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Tasks(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
