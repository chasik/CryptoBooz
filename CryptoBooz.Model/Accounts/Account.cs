using System;
using System.Collections.Generic;
using CryptoBooz.Model.Exchanges;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Accounts
{
    public class Account : IAccount
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime? Deleted { get; set; }

        public virtual ICollection<Exchange> Exchanges { get; set; }
    }
}
