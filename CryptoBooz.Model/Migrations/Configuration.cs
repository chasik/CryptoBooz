using System.Data.Entity.Migrations;
using CryptoBooz.Model.Enums;
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
                new Exchange { Id = (short)ExchangeEnum.Yobit, Name = "YObit.net", BaseUrl = "https://yobit.net" },
                new Exchange { Id = (short)ExchangeEnum.Exmo, Name = "Exmo.me", BaseUrl = "https://exmo.me" }
            );

            base.Seed(context);
        }
    }
}
