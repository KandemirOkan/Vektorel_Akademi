using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Connectionstring = @"Server=LAPTOP-04DDO8B5;Database=NORTHWND;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(Connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from Categories";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<Categories> categories1 = new List<Categories>();
            while (reader.Read())
            {
                Categories categories = new Categories()
                {
                    CategoryID = Convert.ToInt32(reader[nameof(Categories.CategoryID)]),
                    CategoryName = Convert.ToString(reader[nameof(Categories.CategoryName)]),
                    Description = Convert.ToString(reader[nameof(Categories.Description)]),
                };
                categories1.Add(categories);
            }
            connection.Close();
            foreach (var item in categories1)
            {
                Console.WriteLine("Categoryname = {0} \t ID = {1} \t Description = {2} ", item.CategoryName, item.CategoryID, item.Description);
            }
            Console.ReadLine();
        }
    }
}
