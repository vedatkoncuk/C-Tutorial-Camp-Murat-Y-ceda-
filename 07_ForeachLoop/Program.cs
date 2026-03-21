using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü ile Dizi Elemanlarını Yazdırma

            //string[] colors = new string[5];

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.Write(i + ". elemanın rengini giriniz: ");
            //    colors[i] = Console.ReadLine();
            //}

            //foreach (string color in colors)
            //{
            //    Console.WriteLine("Renk: " + color);
            //}


            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa", "Adana" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine("Şehir: " + x);
            //}


            //int[] numbers = { 4, 34, 64, 23, 66, 78, 92, 56 }; 

            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine($"dizideki çift elemanlar {number}");
            //    }
            //}


            //string word = "World";

            //foreach(char s in word)
            //{

            //    Console.WriteLine(s);

            //}


            #endregion


            #region Örnek Sınav Sistemi Uygulaması 

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine("\n");

            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıf mevcudunu giriniz: ");

            //int classSize = int.Parse(Console.ReadLine());

            //Console.WriteLine("------------------------------");

            //string[] studentNames = new string[classSize];

            //double[] studentGrades = new double[classSize];

            //for (int i = 0; i < classSize; i++)
            //{
            //    Console.Write($"Öğrenci {i + 1} adını giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalGrade = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Öğrenci {i + 1}'nin {j + 1}.notunu giriniz: ");
            //        studentGrades[i] = double.Parse(Console.ReadLine());
            //        totalGrade += studentGrades[i];
            //    }
                
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması {totalGrade / 3} ");
                

            //    if (totalGrade / 3 >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci sınavı geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci sınavı geçemedi.");
            //    }

            //    Console.WriteLine("------------------------------\n");
            //}


            #endregion




        }
    }
}
