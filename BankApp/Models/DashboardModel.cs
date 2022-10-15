using BankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankApp.Models
{
    public class DashboardModel : BaseViewModel
    {
        private bool buttonShow = true;
        public bool ButtonShow
        {
            get => buttonShow;
            set
            {
                buttonShow = value;
                OnPropertyChanged(nameof(ButtonShow));
            }
        }

        private bool buttonHide = false;
        public bool ButtonHide
        {
            get => buttonHide;
            set
            {
                buttonHide = value;
                OnPropertyChanged(nameof(ButtonHide));
            }
        }
        
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
        
        private bool hideAmount = false;
        public bool HideAmount
        {
            get => hideAmount;
            set
            {
                hideAmount = value;
                OnPropertyChanged(nameof(HideAmount));
            }
        }
    }
}
