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

          
            Tasks Setting = new(a, b, c);

            Solver Sol = new(Setting);

            ResponseOutput Outt = new(Sol);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.Write(new string('-', 20));
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Outt.Message);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}