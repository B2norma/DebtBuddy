using DebtBuddy.Forms.ViewModels;
using System;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Views
{
    public partial class AccountsPage : ContentPage
    {
        public AccountsPage()
        {
            InitializeComponent();
            BindingContext = new AccountsViewModel();
        }
    }
}

