/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:CryptoBooz.Client.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using System;
using CryptoBooz.Client.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using CryptoBooz.Client.Model;
using CryptoBooz.Client.Services;
using CryptoBooz.Model;
using CryptoBooz.Parsers;
using CryptoBooz.Parsers.Interfaces;

namespace CryptoBooz.Client.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                SimpleIoc.Default.Register<BoozContext>();
                SimpleIoc.Default.Register<IDataService, DataService>();

                SimpleIoc.Default.Register<IParser, Parser>();
            }

            SetupNavigation();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ExchangesViewModel>();
            SimpleIoc.Default.Register<AccountsViewModel>();
            SimpleIoc.Default.Register<ProcessViewModel>();
            SimpleIoc.Default.Register<ProxiesViewModel>();

        }

        private static void SetupNavigation()
        {
            var navigationService = new FrameNavigationService();

            navigationService.Configure("ExchangesView", new Uri("../Views/ExchangesView.xaml", UriKind.Relative));
            navigationService.Configure("AccountsView", new Uri("../Views/AccountsView.xaml", UriKind.Relative));
            navigationService.Configure("ProxiesView", new Uri("../Views/ProxiesView.xaml", UriKind.Relative));
            navigationService.Configure("ProcessView", new Uri("../Views/ProcessView.xaml", UriKind.Relative));

            SimpleIoc.Default.Register<IFrameNavigationService>(() => navigationService);
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ExchangesViewModel Exchanges => ServiceLocator.Current.GetInstance<ExchangesViewModel>();

        public AccountsViewModel Accounts => ServiceLocator.Current.GetInstance<AccountsViewModel>();

        public ProcessViewModel Process => ServiceLocator.Current.GetInstance<ProcessViewModel>();

        public ProxiesViewModel Proxies => ServiceLocator.Current.GetInstance<ProxiesViewModel>();


        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}