using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoBooz.Model.Exchanges;

namespace CryptoBooz.Client.Interfaces
{
    public interface IDataService
    {
        Task<List<Exchange>> Exchanges();

        void CommitChanges();
    }
}
