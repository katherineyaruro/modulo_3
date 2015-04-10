using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEspañol
{
    class Program
    {
        static void Main(string[] args)
        {
           string numero;
            Console.WriteLine("Digite el Numero en letras:");
            numero = Console.ReadLine();
            switch (numero)
            {
                case 1:
                    Console.WriteLine("El numero digitado fue Uno ");
                    break;
                case 2:
                    Console.WriteLine("El numero digitado fue Dos");
                    break;
                case 3:
                    Console.WriteLine("El numero digitado fue Tres");
                    break;
                case 4:
                    Console.WriteLine("El numero digitado fue Cuarto");
                    break;
                case 5:
                    Console.WriteLine("El numero digitado fue Cinco");
                    break;
                default:
                    Console.WriteLine("Fuera del rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
