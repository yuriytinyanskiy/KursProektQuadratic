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
       
        private double a, b, c, d;

      
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
       
        public void Solve() 
        {
            
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Message = "Відповідь: 'X' можее бути будь-яким числом";
                    }
                    else
                    {
                        Message = "Рівняння не має рішень";
                    }
                }
                else
                {
                    double x = -c / b;

                    X1 = x;
                    Message = ($"Відповідь: рівнення має один корінь");
                }

            }
            else
            {
                double d = Diskr(a, b, c);
              
                D = d;

                if (d == 0)
                {
                    double x = -b / (2 * a);

                    X1 = x;
                    Message = ($"Відповідь: рівнення має один корінь");
                }
                else if (d < 0)
                {
                    Message = ($"Відповідт: Коренів немає");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    X1 = x1;
                    X2 = x2;

                    Message = ($"Відповідь: рівнення має два кореня");

                    
                }
            }
           
        }
    }
}
