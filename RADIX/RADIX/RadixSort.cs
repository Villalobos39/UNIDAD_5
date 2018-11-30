using System;
using System.Collections.Generic;
using System.Text;

namespace RADIX
{
    class RadixSort
    {
        static void RSort(int[] arr)
        {
            int comienzo, final;//comienza la creacion de las variables 
            int[] tmp = new int[arr.Length]; // el agreglo de almacebaniento 
            //temporal del arreglo 
            for (int cambio = 31; cambio > -1; --cambio)
            { 
                //el cambio de posicion dento del arreglo
                final = 0;
                for (comienzo = 0; comienzo < arr.Length; ++comienzo)
                {//comienza con la evaluavion dell valor final 
                    bool move = (arr[comienzo] << cambio) >= 0;
                    if (cambio == 0 ? !move : move)
                        //si su pocicion existe un elemento cuyo valor es 
                        arr[comienzo - final] = arr[comienzo];
                    else // evaluado dependiendo de su valor 
                        tmp[final++] = arr[comienzo];
                } // comenzamos con el cambio 
                Array.Copy(tmp, 0, arr, arr.Length - final, final);
            }
        }

        public void Metod1()
        {
            // el arreglo a evaluar es 
            int[] arreglo = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
            Console.WriteLine("\nSERIE : ");
            foreach (var item in arreglo)
            {
                Console.Write(" " + item);
            }
            //se imprime el acomodo final del preceso
            RSort(arreglo);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arreglo)
            {
                Console.Write(" " + item);
            }

        }
        public void Metod2()
        {// practicamente igual que el metodo anterior
            int[] arr = new int[] { 8,3,9,3,11,7,1,2,7,12};
            Console.WriteLine("\nSERIE : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            RSort(arr);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

        }
        public void Metod3()
        {
            int[] arr = new int[] {10,40,36,-5,2,4,2,5,8};
            Console.WriteLine("\nSERIE : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            RSort(arr);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

        }
        public void Metod4()
        {
            int[] arr = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            Console.WriteLine("\nSERIE : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            RSort(arr);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
        }

        public void Metod5()
        {
            int[] arr = new int[] {25,108,1024,12,351,251,39};
            Console.WriteLine("\nSERIE : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            RSort(arr);
            Console.WriteLine("\nRADIX : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

        }
    }
}
