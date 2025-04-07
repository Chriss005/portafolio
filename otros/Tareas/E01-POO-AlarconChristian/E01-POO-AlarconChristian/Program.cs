using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_POO_AlarconChristian
{
    public class Program
    {
        public static int Aleatorio(int inicio, int fin)
        {
            Random randon = new Random();
            return randon.Next(inicio, fin+1);
        }
        public static void mostarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void llenarMatrizAleatorios(int[,] matriz, int inicio, int fin)
        {
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(inicio, fin+1);
                }
            }
        }
        public static void llenarMatrizAleatorios(int[,] matriz)
        {
            Random random = new Random();
            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    cont++;
                    matriz[i, j] = cont;
                }
            }
        }
        public static int[,] matrizTranspuesta(int[,] matriz)
        {
            int[,] matrizz = new int[matriz.GetLength(0), matriz.GetLength(1)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizz[j, i] = matriz[i, j];
                }
            }
            return matrizz;
        }
        public static bool evaluarSimetrica(int[,] matriz)
        {
            bool simetrica = false;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[j,i] == matriz[i,j])
                    {
                        simetrica = true;
                    }
                }
            }
            return simetrica;
        }
        static void Main(string[] args)
        {
            //1.
            int num = Aleatorio(2, 5);
            Console.WriteLine(num);
            //2.
            int m = 4;
            int n = 4;
            int[,] matriz = new int[m,n];
            //3.
            int inicio = 1;
            int fin = 10;
            Console.WriteLine("Matriz de aleatorios: ");
            llenarMatrizAleatorios(matriz, inicio, fin);
            mostarMatriz(matriz);
            //4.

            //5.

            //6.

            //7.

            Console.WriteLine("Matriz transpuesta: ");
            int[,] matriz2 = new int[m, n];
            llenarMatrizAleatorios(matriz2);
            mostarMatriz(matriz2);
            Console.WriteLine();
            int[,] matriz5 = matrizTranspuesta(matriz2);
            mostarMatriz(matriz5);

            //8.
            Console.WriteLine("Matriz simetrica: ");
            int[,] matriz3 = new int[m, n];
            llenarMatrizAleatorios(matriz3);
            Console.WriteLine("Matriz: ");
            mostarMatriz(matriz3);
            Console.WriteLine("Simetrica: " + evaluarSimetrica(matriz3));
        }
    }
}
