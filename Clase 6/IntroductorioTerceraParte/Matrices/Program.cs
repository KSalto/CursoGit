using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fila, columna;
            Console.WriteLine("Ingrese la cantidad de filas de la matriz: ");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas de la matriz: ");
            columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columna];

            Console.WriteLine("Comenzamos el llenado de la matriz");
            for (int i=0; i<matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Fila {i + 1} columna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

            //MUESTRA LA MATRIZ

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }

                Console.WriteLine();
            }
            Console.ReadKey();


            //MUESTRA SOLO LA DIAGONAL PRINCIPAL


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j]);
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            //MUESTRA SOLO LA ULTIMA FILA

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[matriz.GetLength(0)-1, j] + " ");

            }
            Console.WriteLine();
            Console.ReadKey();


            //MUESTRA EL ELEMENTO MAYOR

            int mayor = matriz[0, 0];
            int fMayor = 0,cMayor=0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (mayor < matriz[i,j])
                    {
                        mayor = matriz[i,j];
                        fMayor = i+1;
                        cMayor = j+1;
                    }
                }
                
            }
            Console.WriteLine($"El mayor es {mayor} y se encuentra en la fila {fMayor} y la columna {cMayor}");
            Console.ReadKey();


            //CLONA LA MATRIZ

            int[,] copia = (int[,])matriz.Clone() ;//int[,] copia = matriz.Clone() as int[,];

            //MUESTRA LA MATRIZ CLONADA
            Console.WriteLine("Matriz clonada");

            foreach(int clonada in copia)
            {
                Console.Write(clonada);
            }
            Console.ReadKey();

            // ---------------------------COMO ORDENAR UNA MATRIZ:---------------------------------------------------

            // 1) CREAMOS UN ARRAY UNIDIMENSIONAL CON LOS ELEMENTOS DE LA MATRIZ
            int[] elementos = new int[copia.Length]; //int[] elementos = new int[fila * columna];
            int k = 0;
            for (int i = 0; i < copia.GetLength(0); i++)
            {
                for (int j = 0; j < copia.GetLength(1); j++)
                {
                    elementos[k++] = copia[i, j];
                }
            }

            // 2) ORDENAMOS EL ARRAY UNIDIMENSIONAL
            Array.Sort(elementos);

            // 3) ARMAMOS LA MATRIZ ORDENADA
            
            k = 0;
            for (int i = 0; i < copia.GetLength(0); i++)
            {
                for (int j = 0; j < copia.GetLength(1); j++)
                {
                    copia[i, j] = elementos[k++];
                }
            }
            // -------------------------------------------------------------------------------------------------------

            //MOSTRAMOS LA MATRIZ ORDENADA
            Console.WriteLine("Matriz ordenada");

            for (int i = 0; i < copia.GetLength(0); i++)
            {
                for (int j = 0; j < copia.GetLength(1); j++)
                {
                    Console.Write(copia[i, j] + " ");

                }

                Console.WriteLine();
            }



            Console.ReadKey();
        }
        
    }
}
