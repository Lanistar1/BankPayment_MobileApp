using BankApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CreateWalletPage())
            {
                BarBackgroundColor = Color.MediumBlue
            };
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
