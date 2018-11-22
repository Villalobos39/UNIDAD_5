using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BURBUJA
{
    class Program
    {
        static void Main(string[] args)
        {
            int  valor= 0;   //INICIO EL ARREGLO 
            int[] burbuja = new int[5] { 2, 3, 1, 5, 4 };
            Console.Write("\nINICIO BURBUJA :  2, 3, 1, 5, 4  \n ");
            for (int contador = 1; contador < burbuja.Length; contador++)
              // EL CICLO  SE EJECUTARA A LO LARGO DE LOS ELEMENTOS DEL ARREGLO
                {
                for (int contar = 0; contar < (burbuja.Length - 1); contar++)
                { // AQUI SE INTERCAMBIA LOS NUMERO DEL ARREGLO 
                    if (burbuja[contador] < burbuja[contar])
                    { // SE ALMACENAN EN UNA VARIABLE TEMPORAL 
                        valor = burbuja[contador];
                        burbuja[contador] = burbuja[contar];
                        burbuja[contar] = valor;
                    }   //UNA VEZ QUE SE ALMACENAN SE AÑADEN AL ARREGLO
                }
            }
            // IMPRIME EL ERREGLO FINAL 
            Console.Write("\nFINAL BURBUJA : ");
            for (int cont = 0; cont < 6; cont++)
                Console.Write("  "+burbuja[cont]);
            Console.ReadKey();
        }
    }
}


