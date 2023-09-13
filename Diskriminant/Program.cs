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

            SettingCoefficients Setting = new();

            string d = Setting.CalculateTheDiscriminant();

            if (!Setting.isDefault)
            {
                SolutionOfEquation Solution = new(Setting.A, Setting.B, Setting.C);

                d = Solution.Solve();
            }
           
            ResponseOutput output = new (d);
        }
    }
}