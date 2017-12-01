using System.Reflection;
using CryptoBooz.Client.Interfaces;
using GalaSoft.MvvmLight;
using CryptoBooz.Client.Model;
using CryptoBooz.Client.Services;
using GalaSoft.MvvmLight.Command;

namespace CryptoBooz.Client.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _welcomeTitle = string.Empty;

        private readonly IDataService _dataService;
        private readonly IFrameNavigationService _navigationService;

        private RelayCommand _exchangesCommand;
        private RelayCommand _accountsViewCommand;
        private RelayCommand _proxiesViewCommand;
        private RelayCommand _processViewCommand;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get => _welcomeTitle;
            set => Set(ref _welcomeTitle, value);
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService, IFrameNavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            WelcomeTitle  = $"Crypto Booz  {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

        #region | Commands |

        public RelayCommand ExchangesViewCommand => _exchangesCommand ??
                                                    (_exchangesCommand = new RelayCommand(() =>
                                                        _navigationService.NavigateTo("ExchangesView")));

        public RelayCommand AccountsViewCommand => _accountsViewCommand ??
                                                   (_accountsViewCommand = new RelayCommand(() =>
                                                       _navigationService.NavigateTo("AccountsView")));

        public RelayCommand ProxiesViewCommand => _proxiesViewCommand ??
                                                  (_proxiesViewCommand = new RelayCommand(() =>
                                                      _navigationService.NavigateTo("ProxiesView")));

        public RelayCommand ProcessViewCommand => _processViewCommand ??
                                                  (_processViewCommand = new RelayCommand(() =>
                                                      _navigationService.NavigateTo("ProcessView")));

        #endregion


        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}