using System.ComponentModel.DataAnnotations;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Messages
{
    public class Message : IHaveId<int>
    {
        public int Id { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }
    }
}
