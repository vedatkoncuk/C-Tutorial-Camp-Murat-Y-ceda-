using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri 

            //string[] isimler = new string[5];
            //isimler[0] = "Ahmet";
            //isimler[1] = "Mehmet";
            //isimler[2] = "Ayşe";
            //isimler[3] = "Fatma";
            //isimler[4] = "Ali";

            #endregion


            #region Dizinin Tüm Elemanlarını Yazdırma

            //string[] colors = new string[5];

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.Write(i + ". elemanın rengini giriniz: ");
            //    colors[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i + ". elemanın rengi: " + colors[i]);
            //}

            #endregion


            #region Dizideki En büyük Sayıyı Bulma

            //int[] myArray = { 4, 34, 64, 23, 66, 78, 92, 56 };

            //int maxNumber = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //   if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine("Dizinin en büyük elemanı: " + maxNumber);

            #endregion


            #region Dizilerde Metotlar 

            //string[] personel = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali" };
            //int diziUzunlugu = personel.Length;

            //Console.WriteLine("Dizi uzunluğu : " + diziUzunlugu);


            //int[] numbers = { 4, 34, 64, 23, 66, 78, 92, 56 };

            //int index = Array.IndexOf(numbers, 66);

            //Console.WriteLine("Dizide 66 sayısı : " + index + " Değerine tekamül eder");


            //int[] numbers = { 4, 34, 64, 23, 66, 78, 92, 56 };
            //Console.WriteLine("Dizinin En büyük elemanı: " + numbers.Max());

            #endregion


            #region Kullanıcıdan Değer alma 

            //string[] cities = new string[5];

            //       for (int i = 0; i < cities.Length; i++)
            //       {
            //           Console.Write(i + ". elemanın şehrini giriniz: ");
            //           cities[i] = Console.ReadLine();
            //       }

            //       for (int i = 0; i < cities.Length; i++)
            //       {
            //           Console.WriteLine($"{i + 1}. girilen şehir :{cities[i]} ");
            //       }



            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(i + ". elemanın sayısını giriniz: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);



            //int[] numbers = { 4, 34, 64, 23, 66, 78, 92, 56 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine($"{numbers[i]} cift sayıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{numbers[i]} tek sayıdır");
            //    }
            //}


            #endregion
        }
    }
}
