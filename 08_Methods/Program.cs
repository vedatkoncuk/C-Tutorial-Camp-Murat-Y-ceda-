using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //void HelloWorld()
            //{
            //    Console.WriteLine("Hello World");
            //}

            //HelloWorld();
            //HelloWorld();
            //HelloWorld();   


            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int result = x + y;
            //    Console.WriteLine(result);
            //}

            //sum();
            //sum();

            #endregion


            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Customer Name: " + customerName);
            //}

            //WriteMethod("Vedat Koncuk");


            //void cutomerCard(string customerName, string cardNumber)
            //{
            //    Console.WriteLine("Customer Name: " + customerName);
            //    Console.WriteLine("Card Number: " + cardNumber);
            //}

            //cutomerCard("Vedat Koncuk", "1234 5678 9012 3456");



            //void sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine(result);
            //}

            //sum(5, 10);
            //sum(20, 30);

            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string GetCustomerName()
            //{
            //    return "Vedat Koncuk";
            //}

            //GetCustomerName();


            //string StudentCard(string studentName, string studentNumber)
            //{
            //    return $"Student Name: {studentName} - Student Number: {studentNumber}";
            //}   

            //Console.WriteLine(StudentCard("Ahmet Yılmaz", "2021001"));



            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capitalCity)
            //{
            //    return $"Country Name: {countryName} - Capital City: {capitalCity}";
            //}

            //string country, capital;

            //country = Console.ReadLine();
            //capital = Console.ReadLine();   



            //Console.WriteLine(CountryCard(country, capital));


            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,67));
            //Console.WriteLine(Sum(35,66));

            #endregion


            #region Örnek Uygulama 

            //string ExamResult(string student, int midterm, int final)
            //{
            //    int average = (midterm + final) / 2;

            //    if (average >= 50)
            //    {
            //        return student + " isimli Öğrenci sınavı geçti";
            //    }
            //    else
            //    {
            //        return student + "Öğrenci sınavı geçemedi";
            //    }
            //}

            //Console.WriteLine(ExamResult("Vedat", 45,78));
            //Console.WriteLine(ExamResult("Cansu", 67, 93));


            #endregion

            

        }
    }
}
