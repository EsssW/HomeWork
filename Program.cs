using System;
using System.IO; // библиотека для работы с файлами

namespace Работа__с_Файлами
{
    
    class Program
    {
        static void Main()
        {   /*
            StreamReader sr = new StreamReader("C:\\.......\\1.txt");
            sr.ReadLine();  // считывает 1 строку // return null если ошибка чтения 
            sr.Read();      // считывает по 1 символу // возращает код символа или -1 если ошибка
            sr.ReadToEnd(); // считывает весь файл сразу
            sr.Close();     // зыкрывает и удаляет из озу 
            //=============================================//
            StreamWriter sw = new StreamWriter("");
            //sw.Write();     
            sw.WriteLine();
            sw.Close();
            */
            //=========================================//
            /*
            StreamReader sr1 = new StreamReader("C:\\Users\\mukht\\Desktop\\1.txt",System.Text.Encoding.Default);
            string s;
            int count = 0;
            string[] s1;
            int k = 0;
            StreamWriter sr2 = new StreamWriter("C:\\Users\\mukht\\Desktop\\1_1.txt");
            while ((s = sr1.ReadLine()) != null)
            {

                s1 = s.Split();
                foreach(string x in s1)
                {
                    if (x != "") k++;
                }
                if (s == "") count++;
                sr2.WriteLine(s);
            }
            Console.WriteLine("Пустых строк = {0}",count);
            Console.WriteLine("Число слов= {0}",k);
            sr2.Close();
            */
            /*
            //=========================================//
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
            file.Close();\
            */
            /*
            //=========================================//
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
            */
            //=========================================//
            //3)Дан файл, описывающий матрицу, написать функцию его транспонирования,
            // результат записать в новый файл
            StreamReader file = new StreamReader("C:\\Users\\mukht\\Desktop\\matrix.txt");
            // Прочитали все строки из файла
            string[] s = File.ReadAllLines("C:\\Users\\mukht\\Desktop\\matrix.txt");

            int[][] array = new int[s.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                //Разбили строку пробелами            
                string[] str = s[i].Trim().Split(' ');
                //Создали массив 
                array[i] = new int[str.Length];
                for (int j = 0; j < str.Length; j++)
                    //Оборезали пробельные символы и преобразовали в целое число
                    array[i][j] = int.Parse(str[j].Trim());
            }
            //Вывод массива на экран
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
            // траспонирование 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    int num = array[i][j];
                    array[i][j] = array[j][i];
                    array[j][i] = num;
                }
            }

            Console.ReadKey(true);

        }
    }
}
