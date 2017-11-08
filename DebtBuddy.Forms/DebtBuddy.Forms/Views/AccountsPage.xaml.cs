using DebtBuddy.Forms.ViewModels;
using System;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Views
{
    public partial class AccountsPage : ContentPage
    {
        private AccountsViewModel _viewModel;

        public AccountsPage()
        {
            InitializeComponent();

            _viewModel = new AccountsViewModel();

            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            _viewModel.LoadAccountsFromDatabase();
        }
    }
}

