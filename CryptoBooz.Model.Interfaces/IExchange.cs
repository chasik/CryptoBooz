namespace CryptoBooz.Model.Interfaces
{
    public interface IExchange : IBoozDirectory<short>, IDeleted
    {
        string BaseUrl { get; set; }

        bool AccountParsingStarted { get; set; }
    }
}
