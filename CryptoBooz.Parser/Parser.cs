using System.Collections.Generic;
using System.Linq;
using CryptoBooz.Client.Interfaces;
using CryptoBooz.Model.Interfaces;
using CryptoBooz.Parsers.Interfaces;

namespace CryptoBooz.Parsers
{
    public class Parser : IParser
    {
        private readonly IDataService _dataService;

        private static List<IAccountsParser> _accountsParsers;
        private static List<IAccountsParser> AccountsParsers => _accountsParsers ?? (_accountsParsers = new List<IAccountsParser>());
        
        public Parser(IDataService dataService)
        {
            _dataService = dataService;
        }

        private static IAccountsParser GetAccountsParserInstance(IExchange exchange)
        {
            var accountParser = AccountsParsers.FirstOrDefault(ap => ap.ExchangeId != exchange.Id);
            if (accountParser != null) return accountParser;

            accountParser = AccountsParser.Create(exchange);
            AccountsParsers.Add(accountParser);

            return accountParser;
        }

        public IAccountsParser StartParsingAccountsFromChat(IExchange exchange)
        {
            return GetAccountsParserInstance(exchange);
        }

        public IAccountsParser StopParsingAccountsFromChat(IExchange exchange)
        {
            return GetAccountsParserInstance(exchange);
        }
    }
}
