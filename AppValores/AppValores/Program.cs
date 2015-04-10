using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValores
{
    class Program
    {
        static void Main(string[] args)
            /*Desarrollar un programa que permita la carga de n valores por teclado
             * y nos muestre posteriormente la suma de los valores ingresados y su promedio.*/
        {
            int contador, numero, contador1;
            int promedio=0; 
            Console.WriteLine("Digite el numero de valores:");
            contador = int.Parse(Console.ReadLine());
            contador1 = contador;
            while (contador > 0)
            {
                Console.WriteLine("Digite el Numero" + contador + ":");
                numero = int.Parse(Console.ReadLine());
                promedio += numero;
                contador--;
            }
            Console.WriteLine("La Suma de los numeros es:"+promedio);
            promedio=promedio/contador1;
            Console.WriteLine("El Promedio de los numeros es:" + promedio);
            Console.ReadKey();

        }
    }
}
