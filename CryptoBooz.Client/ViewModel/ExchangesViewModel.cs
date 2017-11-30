using CryptoBooz.Client.Model;
using GalaSoft.MvvmLight;

namespace CryptoBooz.Client.ViewModel
{
    public class ExchangesViewModel : ViewModelBase
    {
        private IDataService _dataService;

        public ExchangesViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
