using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    struct SettingCoefficients
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool isDefault = false;


        public SettingCoefficients()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.Write(new string('-', 20));
            Console.WriteLine(" ");

            Console.WriteLine("Введіть а:"); 
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть c:");
            C = Convert.ToDouble(Console.ReadLine());
        }

        public string CalculateTheDiscriminant()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        isDefault = true;

                        return "Відповідь: 'x' можее бути будь-яким числом";
                    }
                    else
                    {
                        isDefault = true;

                        return "Рівняння не має рішень";
                    }
                }
                else
                {
                    isDefault = true;
                    double x = -C / B;

                    return ($"Відповідь: корінь рівнення x = {x}");               
                }
                            
            }
            else
            {
                return "Solve the equation";
            }
        }

    }
}
