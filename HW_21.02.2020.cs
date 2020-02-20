using System;

namespace _14._02._2020
{
    class Program
    {
        // удалить строчку с максимальным количеством нулем. заполнить 0 и 1
        // поменятть меставми столбцы матрицы так что бы элемнеты первой строки были упорядоченнны 1>2>3>4>5
        // развернуть элемнеты матрицы на 90 граудсов 
        // найти все седлвыеточки матрицы
        static int[,] Sortbyfirststr(int[,] arr,int n, int m)
        {
            int index, max;
            int c = m - 1;
            while (c > 0)
            {
                index = 0;
                for (int j = 1; j <= c; j++)
                    if (arr[0, j] > arr[0, index])
                        index = j;
                for (int i = 0; i < n; i++)
                {
                    max = arr[i, index];
                    arr[i, index] = arr[i, c];
                    arr[i, c] = max;
                }
                c -= 1;
            }
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
            return arr;
        }
        static int[,] Dellitmaxwtrwithzero(int[,] arr, int n, int m)
        {
            int[,] n_arr = new int[n - 1, m];
            int max0 = 0, coll = 0, t = 0, index = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        coll++;
                    }
                }
                if (coll > max0)
                {
                    max0 = coll;
                    index = i;
                    coll = 0;
                }
            }
            for (int i = 0; i < n; i++, t++)
            {
                if (i == index)
                { continue; }
                else for (int j = 0; j < m; j++)
                    {
                        n_arr[t, j] = arr[i, j];
                    }
                t++;

            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(n_arr[i, j] + " ");
                Console.WriteLine();
            }
            return n_arr;
        } //не робит
        static int[,] Rotate(int[,] arr, int n, int m)
        {
            Console.WriteLine("\nМатрица развернута на 90 градусов");
            for (int j = 0; j < m; j++)
            {
                for (int i = n-1; i >= 0; i--)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            return arr;
        }
        static void Searchpint(int[,] a, int N, int M)
        {
            bool f=false;
            int x = 0;
            int[] max_column = new int[M];
            int[] max_str = new int[N];
            int[] min_colum = new int[M];
            int[] min_str = new int[N];
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < N; i++) //цикл для нахождения макисмума и минимума по строкам
            {
                max = min = a[i, 0]; 
                for (int j = 1; j < M; j++)
                {
                    x = a[i, j];
                    if (x < min) min = x;
                    if (x > max) max = x;
                }
                max_str[i] = max; 
                min_str[i] = min;
            }

            for (int i = 0; i< M; i++) // цикл нахождения маисума и минимума по столбцам
            {
                max = min = a[0, i];
                for (int j = 1; j < N; j++)
                {
                    x = a[j, i];
                    if (x < min) min = x;
                    if (x > max) max = x;
                }
                max_column[i] = max;
                min_colum[i] = min;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (a[i, j] == max_column[j] && a[i, j] == min_str[i] || a[i, j] == min_colum[j] && a[i, j] == max_str[i])
                    {
                        Console.WriteLine("седловая точка ({0}, {1}) = {2}", i, j, a[i, j]);
                        f = false;
                    }
                    else f = true;
                    
                }
                
            }
            if (f==true) Console.WriteLine("седловых точек нет");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите размр матрицы");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Random r = new Random();
            Console.WriteLine("\nОснавная матрица: ");
            for (int i = 0; i < n; i++) // заполнение и вывод
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next(0,10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Rotate(arr, n, m);
            Console.WriteLine();
            Sortbyfirststr(arr, n, m);
            Console.WriteLine();
            Searchpint(arr, n, m);
           





        }
    }
}
