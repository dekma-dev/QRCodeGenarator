using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using Microsoft.EntityFrameworkCore;


namespace QRCodeGenarator
{
    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
    }

    public class SQLClass : DbContext
    {
        public DbSet<User> users { get; set; } = null!;

        public SQLClass(/*DbContextOptionsBuilder optionsBuilder*/)
        {
            try
            {
                Database.EnsureCreated(); //не нужно, поскольку таблица будет создана в любом случае
                //else throw new Exception("Failed connection");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            //optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=postgres;Username=postgres;Password=");
        }

        /// <summary>
        /// запихнуть бы это в конструктор в виде необязательного параметра
        /// тогда можно будет легко устанавливать соединение и его проверять
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=postgres;Username=postgres;Password=");
        }
    }
}