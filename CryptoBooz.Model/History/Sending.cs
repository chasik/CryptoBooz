using System;
using CryptoBooz.Model.Exchanges;
using CryptoBooz.Model.Interfaces;
using CryptoBooz.Model.Messages;
using CryptoBooz.Model.Users;

namespace CryptoBooz.Model.History
{
    public class Sending : IHaveId<long>, ICreated
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }

        public int UserId { get; set; } 
        public virtual User User { get; set; }

        public short ExchangeId { get; set; }
        public virtual Exchange Exchange { get; set; }

        public int MessageId { get; set; }
        public virtual Message Message { get; set; }
    }
}
