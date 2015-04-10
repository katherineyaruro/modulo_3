using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Digite el Numero en letras:");
            numero=Console.ReadLine();
            switch(numero.ToUpper())
            {
                case"UNO":
                    Console.WriteLine("El numero digitado fue 1");
                    break;
                case"DOS":
                    Console.WriteLine("El numero digitado fue 2");
                    break;
                 case"TRES":
                    Console.WriteLine("El numero digitado fue 3");
                    break;
                 case "CUATRO":
                    Console.WriteLine("El numero digitado fue 4");
                    break;
                 case "CINCO":
                    Console.WriteLine("El numero digitado fue 5");
                    break;
                default:
                    Console.WriteLine("Fuera del rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
