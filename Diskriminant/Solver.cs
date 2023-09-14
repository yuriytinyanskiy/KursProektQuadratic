using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quadratic
{
    public class Solver
    {
        private double a, b, c, d, x1, x2;
        private string? message = null;
      
        public Solver(Tasks Setting)
        {
            a = Setting.A;
            b = Setting.B;
            c = Setting.C;
        }

        private double Diskr (double a, double b, double c)
        {
            d = Math.Pow(b, 2) - 4 * a * c;
           
            return d;
        }
       
        public DisplayResalt Solve() 
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        message = "Відповідь: 'X' можее бути будь-яким числом";
                    }
                    else
                    {
                        message = "Рівняння не має рішень";
                    }
                }
                else
                {
                    x1 = -c / b;

                    message = ($"Відповідь: рівнення має один корінь");
                }
            }
            else
            {
                Diskr(a, b, c);

                if (d == 0)
                {
                    x1 = -b / (2 * a);

                    message = ($"Відповідь: рівнення має один корінь");
                }
                else if (d < 0)
                {
                    message = ($"Відповідь: Коренів немає");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    message = ($"Відповідь: рівнення має два кореня");
                }
            }

            var result = new DisplayResalt(message, d, x1, x2);

            return (result);
        }
    }
}
