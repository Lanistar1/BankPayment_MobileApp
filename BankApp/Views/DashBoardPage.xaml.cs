using BankApp.Models;
using BankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static BankApp.Models.DashboardModel;

namespace BankApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage
    {
        //private string transType;

        private bool showAmount = true;
        public bool ShowAmount
        {
            get => showAmount;
            set
            {
                showAmount = value;
                OnPropertyChanged(nameof(ShowAmount));
            }
        }
        
        private bool uSDAmount = false;
        public bool USDAmount
        {
            get => uSDAmount;
            set
            {
                uSDAmount = value;
                OnPropertyChanged(nameof(USDAmount));
            }
        }

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

        //private void transTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Picker picker = sender as Picker;
        //    transType = picker.SelectedItem.ToString();
        //    if (transType == "USD Account")
        //    {
        //        USDAmount = true;
        //        ShowAmount = false;
        //    }
        //    else
        //    {
        //        USDAmount = false;
        //        ShowAmount=true;
        //    }
        //}
    }
}