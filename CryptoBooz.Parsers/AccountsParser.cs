using System;
using System.Threading;
using CryptoBooz.Model.Enums;
using CryptoBooz.Model.Interfaces;
using CryptoBooz.Parsers.Interfaces;
using RestSharp;

namespace CryptoBooz.Parsers
{
    public class AccountsParser : IAccountsParser
    {
        private Timer _timer;

        private RestClient _restClient;
        private readonly string _parserUrl;

        public short ExchangeId { get; set; }

        public AccountsParser(string parserUrl)
        {
            _parserUrl = parserUrl;
        }

        public static IAccountsParser Create(IExchange exchange)
        {
            switch (exchange.Id)
            {
                case (short) ExchangeEnum.Yobit:
                    return new YobitAccountsParser(exchange.AccountsParseUrl);
                case (short) ExchangeEnum.Exmo:
                    return new ExmoAccountsParser(exchange.AccountsParseUrl);
            }

            throw new ArgumentOutOfRangeException($"Для {exchange.Name} не реализован AccountParser.");
        }

        public void Start()
        {
            _timer = _timer ?? (_timer = new Timer(StartAccountsParser));

            _timer.Change(0, 60000);
        }

        public void Stop()
        {
            _timer?.Change(Timeout.Infinite, Timeout.Infinite);
        }

        protected virtual void StartAccountsParser(object state)
        {
            _restClient = new RestClient(_parserUrl);
        }

        protected IRestResponse RestClientExecute(RestRequest request)
        {
            return _restClient.Execute(request);
        }
    }
}
