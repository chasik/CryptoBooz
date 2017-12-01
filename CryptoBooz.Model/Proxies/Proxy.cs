using System;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Proxies
{
    public class Proxy : IProxy
    {
        public int Id { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public DateTime? Deleted { get; set; }

        public DateTime? LastUsed { get; set; }
    }
}
