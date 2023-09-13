using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    public class Solver
    {
        public string Message {get; set;}
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Solver(Tasks Setting)
        {
            A = Setting.A;
            B = Setting.B;
            C = Setting.C;
      
            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        Message = "Відповідь: 'x' можее бути будь-яким числом";
                    }
                    else
                    {
                        Message = "Рівняння не має рішень";
                    }
                }
                else
                {
                    double x = -C / B;

                    Message = ($"Відповідь: корінь рівнення x = {x}");
                }

            }
            else
            {
                double d = Math.Pow(B, 2) - 4 * A * C;

                if (d == 0)
                {
                    double x = -B / (2 * A);

                    Message = ($"Відповідь: D = {d}, один корінь x = {x}");
                }
                else if (d < 0)
                {
                    Message = ($"D = {d}, Коренів немає");
                }
                else
                {
                    double x1 = (-B + Math.Sqrt(d)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(d)) / (2 * A);

                    Message = ($"Відповідь: D = {d}, два кореня x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
