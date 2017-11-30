using GalaSoft.MvvmLight.Views;

namespace CryptoBooz.Client.Services
{
    /// <summary>
    /// https://stackoverflow.com/questions/28966819/mvvm-light-5-0-how-to-use-the-navigation-service
    /// </summary>
    public interface IFrameNavigationService : INavigationService
    {
        object Parameter { get; }
    }
}
