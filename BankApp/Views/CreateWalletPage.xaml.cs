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
    public partial class CreateWalletPage : ContentPage
    {
        public CreateWalletPage()
        {
            InitializeComponent();
        }

        private void created_wallet(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DashBoardPage());
        }
    }
}