using BankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage
    {
        public DashBoardPage()
        {
            InitializeComponent();
            BindingContext = new DashBoardViewModel(Navigation);
        }

        private void tap_me(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TransferTypePage());
        }

        private void Fund_successful(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FundWalletPage());
        }
    }
}