using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha A forma geométrica: quadrado, retângulo, trapézio ou losango ");
                string fg = Console.ReadLine ();

            switch (fg)
            {
                case "quadrado":
                    Console.WriteLine("Digite o valor do lado do quadrado que você deseja calcular: ");
                     double vq = double.Parse(Console.ReadLine());
                     double r1 = vq * vq;
                    Console.WriteLine("A área do quadrado é de " + r1);
                    break;

                case "retângulo":
                    Console.WriteLine("Digite o valor da base do retângulo que você deseja calcular: ");
                     double br = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura do retângulo que você deseja calcular: ");
                     double hr = double.Parse(Console.ReadLine());
                     double r2 = br * hr;
                    Console.WriteLine("A área do retângulo é de " + r2);
                    break;

                case "losango":
                    Console.WriteLine("Digite o valor da diagonal maior do losango que você deseja calcular: ");
                     double Dm = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da diagonal menor do losango que você deseja calcular: ");
                     double dm = double.Parse(Console.ReadLine());
                    double r3 = (Dm * dm)/2;
                    Console.WriteLine("A área do losango é de " + r3);
                break;

                case "trapézio":
                    Console.WriteLine("Digite o valor da primeira base do trapézio que você deseja calcular: ");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da segunda base do trapézio que você deseja calcular: ");
                     double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura do trapézio que você deseja calcular: ");
                     double h = double.Parse(Console.ReadLine());
                    double r4 = (b1 + b2) * h /2;
                    Console.WriteLine("A área do trapézio é de " + r4);
                    break;
                Console.ReadKey();
            }
        }
    }
}
