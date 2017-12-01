using System;
using CryptoBooz.Model.Enums;
using CryptoBooz.Model.Interfaces;
using CryptoBooz.Parsers.Interfaces;

namespace CryptoBooz.Parsers
{
    public class AccountsParser : IAccountsParser
    {
        public short ExchangeId { get; set; }

        public static IAccountsParser Create(IExchange exchange)
        {
            switch (exchange.Id)
            {
                case (short) ExchangeEnum.Yobit:
                    return new YobitAccountsParser();
                case (short) ExchangeEnum.Exmo:
                    return new ExmoAccountsParser();
            }

            throw new ArgumentOutOfRangeException($"Для {exchange.Name} не реализован AccountParser.");
        }
    }
}
