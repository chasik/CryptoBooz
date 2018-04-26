using System;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Parsers.Interfaces
{
    public interface IParser
    {
        IAccountsParser StartParsingAccountsFromChat(IExchange exchange);
        IAccountsParser StopParsingAccountsFromChat(IExchange exchange);
    }
}
