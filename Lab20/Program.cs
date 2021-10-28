using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double Calculation(double R);
        static void Main(string[] args)
        {
            Console.Write("Радиуc R=");
            double R = Convert.ToDouble(Console.ReadLine());

            Calculation calc = CirkleLenght; 
            double result = calc(R); 
            Console.WriteLine($"Длина окружности {result:#.####}");

            calc = CirkleArea; 
            result = calc(R);
            Console.WriteLine($"Площадь окружности {result:#.####} "); 

            calc = SphereVol; 
            result = calc(R); 
            Console.WriteLine($"Объем сферы {result:#.####}");

            Console.ReadKey();
        }
        private static double CirkleLenght(double R)
        {
            return 2 * Math.PI * R;
        }
        private static double CirkleArea(double R)
        {
            return Math.PI * Math.Pow(R,2);
        }
        private static double SphereVol(double R)
        {
            return (4/3)*Math.PI * Math.Pow(R, 3);
        }
    }
    
}
