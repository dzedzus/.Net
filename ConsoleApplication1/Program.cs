using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            
            List<Stock> lista = new List<Stock>();
            lista.Add(new Stock("dupa", 12, "chuj"));
            lista.Add(new Stock("dupa1",122 , "chuj"));
            
            using ( var context = new DatabaseContext(connectionString))
            {
                foreach (var stock in lista)
                {
                    context.Stocks.Add(stock);
                    context.SaveChanges();
                }
                

            }

        }
        public class DatabaseContext : DbContext
        {
            public DatabaseContext(string connectionString)
                : base(connectionString)
            {
            }


            public DbSet<Stock> Stocks { get; set; }
        }
    }
}
