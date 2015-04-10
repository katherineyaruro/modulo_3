using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resul;
            Console.WriteLine("Progama que lee 2 números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.");
            Console.WriteLine("Digite el 1er Numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el 2do Numero");
            num2 = float.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                resul = num1 + num2;
                Console.WriteLine("El 1er Numero es mayor y su suma es:" + resul);
                resul = num1 - num2;
                Console.WriteLine("Y la diferencia entre los 2 es:" + resul);
            }
            else {
                resul = num1 * num2;
                Console.WriteLine("El 1er numero es menor y su producto es:" + resul);
                resul = num1 / num2;
                Console.WriteLine("El 1er numero es menor y su division es:" + resul);

            }
            Console.ReadKey();
        }
    }
}
