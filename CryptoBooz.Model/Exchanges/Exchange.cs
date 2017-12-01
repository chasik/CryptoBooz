using System;
using System.Collections.Generic;
using CryptoBooz.Model.Accounts;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Exchanges
{
    public class Exchange : IExchange
    {
        public short Id { get; set; }

        public string Name { get; set; }

        public DateTime? Deleted { get; set; }

        public string BaseUrl { get; set; }

        public bool AccountParsingStarted { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
