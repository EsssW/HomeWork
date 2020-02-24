using System;

namespace HW_21._02._2020
{
    class Program
    {
        // находитвсе целочисленные корни уравнение n-ой степени Xn-1X^n+An-2X^n-1+An-3
       
        static void Proverka1(int[] kf,int n )
        {
            bool b_min = false, b_plus = false;
            int schetn = 0;
            int snchet = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += kf[i];

            if (sum == 0) 
            {
                b_plus = true;
                Console.WriteLine(" \"1\" является корнем");
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) schetn += kf[i];
                else snchet += kf[i];
            }
            if (snchet == snchet)
            {
                b_min = true;
                Console.WriteLine("\"-1\" являеться корнем ");
            }
            
        }
        public static int[] SearchDelliteley(int[] kf)
        {
            int j = 0;
            int count = 0;
            int lastkf = kf[kf.Length];     // записали свобоный член уравнения
            for (int i = 1; i <= lastkf; i++) // подсчет числа делитлей
            {
                if (lastkf % i == 0)
                {
                    count++;
                }
            }
            int[] deliteli = new int[count];  //массив для записи всех делителей свобоного члена
            for (int i = 1; i <= lastkf; i++) // запись всех делителей
            {
                if (lastkf % i == 0)
                {
                    deliteli[j] = i;
                    j++; 
                }
            }
            return deliteli;2
        }
        static int[] ProverkaDelliteley(int[] deliteli,int[] kf)
        {
            int[] result = new int[deliteli.Length];
            int[] korni = new int[deliteli.Length]; // для записи корней которые подошли
            int n = kf.Length;     //кол-во степенией 
            for (int i = 0; i < deliteli.Length; i++)
            {
                for (int j = 0; j < kf.Length; j++)
                {
                    result[i] += kf[j] * (int)Math.Pow(deliteli[i], n-i); 
                }
            }
            for (int i = 0; i < deliteli.Length; i++) 
            {
                if (result[i] == 0)
                {
                    korni[i] = result[i];
                }
            }
            return korni;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число вещественных аргументов");
            int n = int.Parse(Console.ReadLine());
            var kf = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("введите {0} коэфициент: ", i + 1);
                kf[i] = int.Parse(Console.ReadLine());
            }
            Proverka1(kf, n); // проверка на 0 и 1
            int[] deliteli=SearchDelliteley(kf);    // поиск делитлей 
            ProverkaDelliteley(deliteli, kf);       // подбор корней по делителям

        }
        
    }
}
