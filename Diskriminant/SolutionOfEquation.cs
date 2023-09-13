using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    internal class SolutionOfEquation
    {
        private double A { get; }
        private double B { get; }
        private double C { get; }

        public SolutionOfEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Solve()
        {
            double d = Math.Pow(B, 2) - 4 * A * C;

            if (d == 0)
            {
                double x = -B / (2 * A);

                return ($"Відповідь: D = {d}, один корінь x = {x}");
            }
            else if (d < 0)
            {
                return ($"D = {d}, Коренів немає");
            }
            else
            {
                double x1 = (-B + Math.Sqrt(d)) / (2 * A);
                double x2 = (-B - Math.Sqrt(d)) / (2 * A);

                return ($"Відповідь: D = {d}, два кореня x1 = {x1}, x2 = {x2}");
            }

        }
    }
}
