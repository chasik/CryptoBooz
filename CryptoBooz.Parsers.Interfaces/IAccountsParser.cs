namespace CryptoBooz.Parsers.Interfaces
{
    public interface IAccountsParser
    {
        short ExchangeId { get; set; }
        void Start();
        void Stop();
    }
}
