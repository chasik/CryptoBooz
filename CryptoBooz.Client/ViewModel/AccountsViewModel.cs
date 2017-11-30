using CryptoBooz.Client.Model;
using GalaSoft.MvvmLight;

namespace CryptoBooz.Client.ViewModel
{
    public class AccountsViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public AccountsViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
