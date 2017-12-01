using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using CryptoBooz.Client.Interfaces;
using CryptoBooz.Client.Model;
using CryptoBooz.Model.Exchanges;
using CryptoBooz.Model.Interfaces;
using CryptoBooz.Parsers.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace CryptoBooz.Client.ViewModel
{
    public class ExchangesViewModel : ViewModelBase
    {
        #region | Fields |

        private readonly IDataService _dataService;
        private readonly IParser _parser;
        private ObservableCollection<IExchange> _exchanges;
        private Exchange _selectedExchange;

        #endregion

        #region | Properties |

        public Exchange SelectedExchange
        {
            get => _selectedExchange;
            set => Set(ref _selectedExchange, value);
        }

        public ObservableCollection<IExchange> Exchanges
        {
            get => _exchanges;
            set => Set(ref _exchanges, value);
        }

        #endregion

        #region | Constructors |

        public ExchangesViewModel(IDataService dataService, IParser parser)
        {
            _dataService = dataService;
            _parser = parser;

            _dataService.Exchanges().ContinueWith(t => Exchanges = new ObservableCollection<IExchange>(t.Result));
        }

        #endregion

        #region | Methods |

        private void AccountSearchSwitch(IExchange exchange)
        {
            exchange.AccountParsingStarted = !exchange.AccountParsingStarted;

            _dataService.CommitChanges();

            var accountParser = exchange.AccountParsingStarted
                ? _parser.StartParsingAccountsFromChat(exchange)
                : _parser.StopParsingAccountsFromChat(exchange);
        }

        #endregion

        #region | Commands |

        private RelayCommand<IExchange> _accountSearchSwitchCommand;

        public RelayCommand<IExchange> AccountSearchSwitchCommand =>
            _accountSearchSwitchCommand ??
            (_accountSearchSwitchCommand = new RelayCommand<IExchange>(AccountSearchSwitch));

        #endregion
    }
}
