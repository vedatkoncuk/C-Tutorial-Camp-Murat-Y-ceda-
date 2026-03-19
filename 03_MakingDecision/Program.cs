using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abc")
            //{
            //    Console.WriteLine("şifre Doğru");
            //} else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}


            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı ");   
            //}


            //double exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}

            //Console.WriteLine(result);


            //string city;

            //Console.WriteLine("Lütfen şehir girişi yapınız");

            //city = Console.ReadLine();

            //if (city == "adana" | city =="ankara")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}



            #endregion

            #region Mod İşlemleri 

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number % number2;
            //Console.WriteLine("1. sayınıın 2. sayıya bölümünden kalan : " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}
            #endregion

            #region Char İşlemler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("****** c# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------");

            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğin menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine(); 
            //    Console.WriteLine("-------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Köri Soslu Tavuk");
            //    Console.WriteLine("Kızartma tabağı");
            //    Console.WriteLine("fırında somon");
            //    Console.WriteLine("patlıcan musakka");
            //    Console.WriteLine("--------Ana Yemekler ----------");

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("mercimek corbası");
            //    Console.WriteLine("ezogelin çorbası");
            //    Console.WriteLine("lahana çorbası");
            //    Console.WriteLine("şehriye çorbası");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("tavuklu pizza ");
            //    Console.WriteLine("margarita");
            //    Console.WriteLine("mantarlı pizza");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("su ");
            //    Console.WriteLine("kola");
            //    Console.WriteLine("soda");
            //}



            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("aüustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi
            
            //int number1,number2, result;

            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("yapmak istediğin işlemi seç:");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //}

            #endregion


        }
    }
}
