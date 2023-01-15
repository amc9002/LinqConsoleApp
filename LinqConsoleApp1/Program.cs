using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace LinqConsoleApp2
{
    class Program
    {
        static string connectionString = "Server=ASUS-PC41;Database=userdb;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext(connectionString))
            {
                //// Получаем таблицу пользователей
                Table<User> users = db.GetTable<User>();

                var query = from u in users
                            where u.Age > 25
                            orderby u.FirstName
                            select u;

                foreach (var user in query)
                {
                    Console.WriteLine("{0} \t{1} \t{2}", user.Id, user.FirstName, user.Age);
                }

                Console.Read();
            }

        }
    }
}