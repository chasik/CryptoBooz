using System;
using System.Reflection;

namespace CryptoBooz.Client.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var item = new DataItem($"Crypto Booz  {version.Major}.{version.Minor}.{version.Build}.{version.Revision}");

            callback(item, null);
        }
    }
}