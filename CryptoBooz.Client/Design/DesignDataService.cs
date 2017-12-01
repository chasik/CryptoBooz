using System.Collections.Generic;
using System.Threading.Tasks;
using CryptoBooz.Client.Interfaces;
using CryptoBooz.Model.Exchanges;

namespace CryptoBooz.Client.Design
{
    public class DesignDataService : IDataService
    {
        public Task<List<Exchange>> Exchanges()
        {
            return Task.Factory.StartNew(() =>
                new List<Exchange>
                {
                    new Exchange {Id = 1, Name = "YObit.net", BaseUrl = "https://yobit.net/"},
                    new Exchange {Id = 2, Name = "EXMO.me", BaseUrl = "https://exmo.me/", AccountParsingStarted = true}
                });
        }

        public void CommitChanges()
        {
        }
    }
}