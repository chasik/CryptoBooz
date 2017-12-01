using CryptoBooz.Client.Interfaces;
using CryptoBooz.Client.Model;
using GalaSoft.MvvmLight;

namespace CryptoBooz.Client.ViewModel
{
    public class ProcessViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public ProcessViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
