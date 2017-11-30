using System.Data.Entity;
using CryptoBooz.Model.Accounts;
using CryptoBooz.Model.Exchanges;
using CryptoBooz.Model.History;
using CryptoBooz.Model.Messages;
using CryptoBooz.Model.Users;
using MySql.Data.Entity;

namespace CryptoBooz.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BoozContext : DbContext
    {
        public BoozContext() : base("CryptoBoozConnectionString")
        {

        }

        public DbSet<Exchange> Exchanges { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Sending> Sendings { get; set; }
    }
}