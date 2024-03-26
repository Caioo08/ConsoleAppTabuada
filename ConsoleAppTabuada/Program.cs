using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.Write("Digite a tabuada: ");
            double tab = double.Parse(Console.ReadLine());
            Console.Write("Digite o número de vezes: ");
            int vezes = int.Parse(Console.ReadLine());

            while (cont <= vezes)
            {
                double multi = tab * cont;
                Console.WriteLine("" +tab+ " x " +cont+ " = " + multi);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
