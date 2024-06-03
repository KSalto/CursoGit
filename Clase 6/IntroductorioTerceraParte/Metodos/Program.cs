using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            string opcion;
            int[,] matrizCargada;
            
            Console.WriteLine("Cargar Matriz");
            matrizCargada = CargarMatriz();
            int[,] matrizOrdenada = matrizCargada.Clone() as int[,];


            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("a) Ver Matriz");
                Console.WriteLine("b) Ordenar Matriz");
                Console.WriteLine("c) Ver Matriz Ordenada");
                Console.WriteLine("x) Salir");
                Console.Write("Elija una opción: ");

                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "a":
                        VerMatriz(matrizCargada);
                        break;
                    case "b":
                        matrizOrdenada=OrdenarMatriz(matrizCargada);
                        break;
                    case "c":
                        VerMatriz(matrizOrdenada);
                        break;
                    case "x":
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion.ToLower() != "x");
            Console.ReadKey();

        }

        static int[,] CargarMatriz()
        {
            int fila, columna;
            Console.WriteLine("Ingrese la cantidad de filas de la matriz: ");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas de la matriz: ");
            columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columna];

            Console.WriteLine("Comenzamos el llenado de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Fila {i + 1} columna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            return matriz;
        }

        static void VerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }

                Console.WriteLine();
            }

        }

        static int[,] OrdenarMatriz(int[,] matriz)
        {
            int[,] copia = matriz.Clone() as int[,];

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

            return copia;

        }
    }
}
