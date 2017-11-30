using CryptoBooz.Client.Model;
using GalaSoft.MvvmLight;

namespace CryptoBooz.Client.ViewModel
{
    public class ExchangesViewModel : ViewModelBase
    {
        #region | Fields |

        private readonly IDataService _dataService;

        #endregion

        #region | Properties |

        

        #endregion

        #region | Constructors |

        public ExchangesViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        #endregion

        #region | Commands |

        

        #endregion
    }
}
