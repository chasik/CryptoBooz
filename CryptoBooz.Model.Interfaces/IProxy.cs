namespace CryptoBooz.Model.Interfaces
{
    public interface IProxy : IHaveId<int>, IDeleted, IUsed
    {
        string Host { get; set; }
        int Port { get; set; }
    }
}
