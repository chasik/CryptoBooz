using System;
using System.Collections.Generic;
using CryptoBooz.Model.Accounts;
using CryptoBooz.Model.Base;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Exchanges
{
    public class Exchange : BoozDirectory<short>, IDeleted
    {
        public DateTime? Deleted { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public string BaseUrl { get; set; }
    }
}
