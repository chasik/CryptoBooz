using System.IO;
using CryptoBooz.Client.Model;
using GalaSoft.MvvmLight;

namespace CryptoBooz.Client.ViewModel
{
    public class ProxiesViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public ProxiesViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
