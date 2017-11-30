using System;
using CryptoBooz.Model.Base;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Proxies
{
    public class Proxy : IHaveId<int>, IDeleted, IUsed
    {
        public int Id { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? LastUsed { get; set; }
    }
}
