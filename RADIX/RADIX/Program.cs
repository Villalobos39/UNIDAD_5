using System;

namespace RADIX
{
    class Program
    {
       static void Main(string[] args)  
        {// creamos el objeto de la clase y mandamos a llamar 
            Console.Write("METODO DE ORDENACION RADIX SORT : \n");
            RadixSort imprimir = new RadixSort();
            // los elementos 
            imprimir.Metod1();
            imprimir.Metod2();
            imprimir.Metod3();
            imprimir.Metod4();
            imprimir.Metod5();


            Console.WriteLine("\n");
        }
    }
}
