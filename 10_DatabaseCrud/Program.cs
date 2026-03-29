using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Menü Sipariş İşlem Paneli ***** ");
            Console.WriteLine();

            Console.WriteLine("---------------------------");

            #region Kategori Ekleme İşlemi 


            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-GEEFC2S6\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion


            #region Ürün Ekleme İşlemi

            //string ProductName;
            //decimal PorductPrice;
            ////bool ProductStatus;

            //Console.Write("Eklemek istediğiniz Ürün Adı: ");
            //ProductName = Console.ReadLine();

            //Console.Write("Ürünn Fiyatı: ");
            //PorductPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-GEEFC2S6\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TbProduct (ProductName, PorductPrice,ProductStatus) VALUES (@p1, @p2, @p3)", connection);

            //command.Parameters.AddWithValue("@p1", ProductName);
            //command.Parameters.AddWithValue("@p2", PorductPrice);
            //command.Parameters.AddWithValue("@p3", true);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion


            #region Ürün listeleme işlemi

            // SqlConnection connection = new SqlConnection("Data Source=LAPTOP-GEEFC2S6\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            // connection.Open();

            // SqlCommand command = new SqlCommand("SELECT * FROM TbProduct", connection);

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            // System.Data.DataTable dataTable = new System.Data.DataTable();
            // dataAdapter.Fill(dataTable);

            // foreach(DataRow row in dataTable.Rows)
            // {
            //     foreach(var item in row.ItemArray)
            //     {
            //         Console.Write(item.ToString() + " ");
            //     }
            //     Console.WriteLine();
            // }

            // connection.Close();

            #endregion


            #region Ürün silme işlemi   

            //Console.Write("Silmek istediğiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-GEEFC2S6\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("delete from TbProduct where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("silme işlemi yapıldı");

            #endregion


            #region Ürün güncelleme işlemi

            //Console.Write("Güncellemek istediğiniz ürünün Id sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellemek istediğiniz ürünün adını giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellemek istediğiniz ürünün fiyatını giriniz: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-GEEFC2S6\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("update TbProduct set ProductName=@productName, PorductPrice=@productPrice where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();  

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion


        }
    }
}
