using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Metodo
    {
        private static void QuickSortD(double[] arreglo, double primero, double ultimo)
        {// // EL METODO QUICKsort RECIBE 3 PARAMETROS POR DEFECTO QUE REPRESENTA 
            int cont1 = (int)primero, cont2 = (int)ultimo;
            int pilar = ((cont1 + cont2) / 2); // EL ARREGLO CON TODOS LOS ELEMENTOS YA INTEGRADOS 
            double pivote = arreglo[pilar];
            do
            {// Y EL PRIMER Y SEGUNDO VALOR QUE SERAN LOS QUE SE COMPARAM 
                while (arreglo[cont1] < pivote) cont1++;
                while (arreglo[cont2] > pivote) cont2--;
                // ESTOS CICLOS DICEN QUE SI EL ELEMTO DEL ARREGLO ES MAYOR O MENOR QUE EL PIVOTE 
                // SE ACOMODAN EN EL PRINCIPIO O FINAL DEPENDIENDO DE SU VALOR
                if (cont1 <= cont2)
                {// CUANDO EL VALOR DEL PRIMERO ES MENOR IGUAL AL ULTIMO
                    double temp = arreglo[cont1];
                    // SE ASIGNA A UNA VARIABLE TEMPORAL CON EL VALOR ASIGNADO 
                    arreglo[cont1] = arreglo[cont2];
                    // ESE VALOR SE INTERCAMBIA DEL LADO ANTES O DESPUES DEL PIVOTE
                    arreglo[cont2] = temp;
                    cont1++; // DEPENDIENDO DE SU EJECUCION LOS VALORES SE 
                    cont2--; // ACOMODAN DE MENOR A MAYOR 
                }
            }
            while (cont1 <= cont2); // EL CICLO TERMINA SI EL PRIMER VAOLOR ES MENOR O IGUAL AL ULTIMO
            if (primero < cont2) QuickSortD(arreglo, primero, cont2); // SI EL PRIMERO VALOR ES MORO O IGUAL AL ULTIMO 
            if (cont1 < ultimo) QuickSortD(arreglo, cont1, ultimo); // SE MANDA A EJECUTAR EL MISMO METODO 
        }

        public void C1()// ARREGLO 1 
        {
            double[] dato = { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 };
            // MANDO A LLAMAR AL METODO QUICK SORT 
            QuickSortD(dato, 0, dato.Length - 1);
            for (int cont = 0; cont < dato.Length; cont++)
                Console.Write(dato[cont].ToString() + " || ");
            // PARA DARLE FORMATO A ALA IMPRESION 
        }

        public void C2() //ARREGLO 2
        {
            double[] dato = { 1,3,5,7,8,3,9,0.7071,16.56,12,0,10}; // RAIZ DE 2 / 2 = 0.7071
            QuickSortD(dato, 0, dato.Length - 1);
            for (int cont = 0; cont < dato.Length; cont++)
                Console.Write(dato[cont].ToString() + " || ");
            // LO MISMO 
        }

        public void C3() //ARREGLO 3
        {
            double[] dato = {3,7,15,1.33,155,100,15,1.73,5,-5,3,2}; // (RAIZ DE 5i )^2 = -5
            QuickSortD(dato, 0, dato.Length - 1);
            for (int cont = 0; cont < dato.Length; cont++)
                Console.Write(dato[cont].ToString() + " || ");
            
        }

        public void C4() //ARREGLO 4
        { 
            double[] dato = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            QuickSortD(dato, 0, dato.Length - 1);
            for (int cont = 0; cont < dato.Length; cont++)
                Console.Write(dato[cont].ToString() + " || ");
            
        }
    }
}
