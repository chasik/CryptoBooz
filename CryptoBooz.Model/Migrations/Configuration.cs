using System.Data.Entity.Migrations;
using CryptoBooz.Model.Exchanges;

namespace CryptoBooz.Model.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BoozContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CryptoBooz.Model.BoozContext context)
        {

            context.Exchanges.AddOrUpdate(
                new Exchange { Id = 1, Name = "YObit.net", BaseUrl = "https://yobit.net" },
                new Exchange { Id = 2, Name = "Exmo.me", BaseUrl = "https://exmo.me" }
            );

            base.Seed(context);
        }
    }
}
