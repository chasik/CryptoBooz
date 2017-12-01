using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoBooz.Client.Interfaces;
using CryptoBooz.Model;
using CryptoBooz.Model.Exchanges;

namespace CryptoBooz.Client.Model
{
    public class DataService : IDataService
    {
        private readonly BoozContext _context;

        public DataService(BoozContext context)
        {
            _context = context;
        }

        public Task<List<Exchange>> Exchanges()
        {
            return Task.Factory.StartNew(() => _context.Exchanges.ToList());
        }

        public void CommitChanges()
        {
            _context.SaveChanges();
        }
    }
}