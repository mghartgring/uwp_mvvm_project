using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using uwp_mvvm_template.Shared.ViewModels;
using Microsoft.Practices.ServiceLocation;
using uwp_mvvm_template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwp_mvvm_template
{
    public class ViewModelLocator
    {
        public MainViewModel MainView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public SecondViewModel SecondView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SecondViewModel>();
            }
        }

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            var nav = new NavigationService();
            nav.Configure("MainPage", typeof(MainPage));
            nav.Configure("SecondPage", typeof(SecondPage));
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();

        }

    }
}
