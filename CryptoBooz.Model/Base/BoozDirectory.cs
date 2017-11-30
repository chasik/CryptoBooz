using System.ComponentModel.DataAnnotations;
using CryptoBooz.Model.Interfaces;

namespace CryptoBooz.Model.Base
{
    public class BoozDirectory<T> : IBoozDirectory<T>
    {
        public T Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
    }
}
