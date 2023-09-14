using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Quadratic
{
    public struct DisplayResalt
    {
        public string? Message { get; }
        public double? D { get; }
        public double? X1 { get; }
        public double? X2 { get; }

        public DisplayResalt (string? a, double? b, double? c, double? d)
        {
            Message = a;
            D = b;
            X1 = c;
            X2 = d;
        }
    }
}
