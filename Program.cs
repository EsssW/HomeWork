using System;

namespace HW_21._02._2020
{
    class Program
    {
        // даны координаты n точек x0 y0.....xn yn точек n треуольников n-1;
       
        static double Ploshad(int[,] a)
        {
            int s1 = 0, s2 = 0;
            for (int i = 0; i < a.GetLength(1) - 1; i++)
            {
                s1 += a[0, i] * a[1, i + 1];
                s2 += a[1, i] * a[0, i + 1];
            }

            return Math.Abs((s1 - s2) / 2d);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во вершин фигуры: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[2, n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите координаты вершины {0}: ", i + 1);
                var input = Console.ReadLine().Split(' ');
                arr[0, i] = int.Parse(input[0]);
                arr[1, i] = int.Parse(input[1]);
            }
            var result = Ploshad(arr);
            Console.WriteLine("Пложадь многоугольника равна {0}", result);
            
        }

    }
}
