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
        private readonly IDataService _dataService;

        private string _welcomeTitle = string.Empty;

        private RelayCommand _exchangesCommand;
        private IFrameNavigationService _navigationService;

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

            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
        }

        #region | Commands |

        public RelayCommand ExchangesViewCommand
        {
            get
            {
                return _exchangesCommand ?? (_exchangesCommand =
                           new RelayCommand(() => _navigationService.NavigateTo("ExchangesView")));
            }
        }

        #endregion


        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}