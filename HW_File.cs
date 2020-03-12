using System;
using System.IO; // библиотека для работы с файлами

namespace Работа__с_Файлами
{
    
    class Program
    {
        static void Main()
        {   
            // 1)Длинна самой длинной строки
            StreamReader file = new StreamReader("C:\\Users\\mukht\\Desktop\\1.txt");

            string maxSTR = "";
            string str;

            while ((str = file.ReadLine()) != null)
            {
                if (str.Length > maxSTR.Length)
                    maxSTR = str;
            }

            Console.WriteLine("Самаядлинна строка= {0}", maxSTR.Length);
            file.Close();
            //===========================================================================================================================//
            //2) Cколько раз данное слово встречаеться в файле
            StreamReader file = new StreamReader("C:\\Users\\mukht\\Desktop\\1.txt");
            Console.WriteLine("Введите слово для поиска");
            string slovo =Console.ReadLine();
            string str;
            int count = 0;
            string[] s1;

            while ((str = file.ReadLine()) != null)
            {
                s1 = str.Split();
                foreach (string x in s1)
                {
                    if (x == slovo) count++;
                }
                    
            }
            Console.WriteLine("Слово {0} всречаелось в файле {1} раз", slovo, count);
            file.Close();
            //===========================================================================================================================//
            //3)Дан файл, описывающий матрицу, написать функцию его транспонирования,
            // результат записать в новый файл
            StreamReader f = new StreamReader("C:\\Users\\mukht\\Desktop\\matrix.txt");//чтение файла (массив в который будем вносить)
            string s;
            int[,] arr;
            string[] strarr;// массив для зписи строки 
            int i = 0;
            while ((s = f.ReadLine()) != null)
            {
                strarr = s.Split(' '); // заполнили строкой разделив пробелом
                arr = new int[strarr.Length, strarr.Length];
                for (int j = 0; j < 4; j++)
                {
                    var t = int.Parse(strarr[j]);
                    arr[i, j] = t;
                    Console.Write(" {0}", arr[i, j]);
                }
                i++;
                Console.WriteLine();
            }
            for (int k = 0; k < arr.Length; k++)
            {
                for (int j = 0; j < k; j++)
                {
                    int change = arr[k, j];
                    arr[k, j] = arr[j, k];
                    arr[j, k] = change;
                }
            }
            StreamReader nmatrix = new StreamReader("C:\\Users\\mukht\\Desktop\\matrix2.txt");
            for (int j = 0; j< arr.Length; j++)
            {
                for (int l = 0; l < arr.Length; l++)
                {
                    nmatrix.WritLine(a[j][l]);
                }
                
            }
            f.Close();
            nmatrix.Close();
        }
    }
}
