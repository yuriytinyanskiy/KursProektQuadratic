namespace Diskriminant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет квадратного уравнения типа: ax2+bx+c=0");
            
            Console.WriteLine("Введите а:");
            double a = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());
            
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Ответ: 'x' может быть любым числом");
                    }
                    else
                    { 
                        Console.WriteLine("Уравнение не имеет решений");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Ответ: корень уравнения x = {x}");
                }
            }
            else
            {
                double d = Math.Pow(b, 2) - 4 * a * c;

                Console.WriteLine($"D = {d}");

                if (d == 0) 
                { 
                    double x = -b / (2 * a);
                    Console.WriteLine($"Ответ: D = 0, один корень x = {x}");
                }
                else if (d < 0) 
                {
                    Console.WriteLine("D < 0, Корней нет");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Ответ: D > 0, два корня x1 = {x1}, x2 = {x2}");
                }

            }
        }
    }
}