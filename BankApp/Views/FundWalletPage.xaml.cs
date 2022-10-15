using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FundWalletPage : ContentPage
    {
        public FundWalletPage()
        {
            InitializeComponent();
        }

        private void Fund_success(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fund_AccountSuccessPage());
        }
    }
}