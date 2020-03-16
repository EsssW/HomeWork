using System;
using System.IO;

namespace HW_FILE
{
    class Student
    {
        public string lastname;
        public string name;
        public byte math;
        public byte proga;
        public byte linal;

        public Student(string lastname, string name, byte math, byte linal, byte proga)
        {
            this.lastname = lastname;
            this.name = name;
            this.math = math;
            this.linal = linal;
            this.proga = proga;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Users\mukht\Desktop\student.txt", Encoding.Default);
            int f = System.IO.File.ReadAllLines(@"C:\Users\mukht\Desktop\student.txt").Length;
            Student[] students = new Student[f]; //массив класса студент 
            string buf ="";
            string[] bufsplit;
            for (int i = 0; i < f; i++)
            {
                buf = file.ReadLine();
                bufsplit = buf.Split(' ');
                students[i] = new Student(bufsplit[0], bufsplit[1], byte.Parse(bufsplit[3]), byte.Parse(bufsplit[4]), byte.Parse(bufsplit[5]));
            }
            StreamWriter newfile = new StreamWriter(@"C: \Users\mukht\Desktop\studentnew.txt");
            byte j = 0;
            for (int i = 0; i < f; i++)
            {
                if ((students[i].math <56) || (students[i].linal < 56) || (students[i].proga < 56))
                {
                    j++;
                    newfile.WriteLine(students[i].lastname + " " + students[i].name + " " + students[i].math + " " + students[i].proga + " " + students[i].linal);
                }
            }
            newfile.Close();
            file.Close();
        }
    }
}
