namespace CryptoBooz.Model.Interfaces
{
    public interface IBoozDirectory<T> : IHaveId<T>
    {
        string Name { get; set; }
    }
}
