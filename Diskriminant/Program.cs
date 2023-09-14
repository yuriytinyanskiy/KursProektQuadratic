using Quadratic;
using System.Text;
using System.Threading.Channels;

namespace Diskriminant
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Розрахунок квадратного рівняння типу: ax2+bx+c=0");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.Write(new string('-', 20));
            Console.WriteLine(" ");
           
            Console.WriteLine("Введіть а:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть c:");
            double c = Convert.ToDouble(Console.ReadLine());

            var solver = new Solver(new Tasks(a, b, c));

            var result = solver.Solve();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.Write(new string('-', 20));
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(result.Message);
            Console.WriteLine($"D = {result.D}");
            if(result.X1 != 0)
            { Console.WriteLine($"X2 = {result.X1}"); }
            if (result.X2 != 0)
            { Console.WriteLine($"X2 = {result.X2}"); }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}