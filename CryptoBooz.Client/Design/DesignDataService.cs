using System;
using System.Reflection;
using CryptoBooz.Client.Model;

namespace CryptoBooz.Client.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var item = new DataItem($"Crypto Booz   {version.Major}.{version.Minor}.{version.Build}.{version.Revision}");

            callback(item, null);
        }
    }
}