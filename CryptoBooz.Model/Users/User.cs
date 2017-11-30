using System;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Users
{
    public class User : IHaveId<int>, IDeleted
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
