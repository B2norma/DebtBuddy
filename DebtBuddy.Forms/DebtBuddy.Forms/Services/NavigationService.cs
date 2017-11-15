using DebtBuddy.Forms.Interfaces.Services;
using DebtBuddy.Forms.Models;
using DebtBuddy.Forms.ViewModels;
using DebtBuddy.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace DebtBuddy.Forms.Services
{
    public class NavigationService : INavigationService
    {
        public async Task PopAsync()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavigateToCreateAccount()
        {
            var viewModel = new CreateAccountViewModel();

            var page = new CreateAccountPage(viewModel);

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public async Task NavigateToAccountDetail(Account account)
        {
            var viewModel = new AccountDetailViewModel(account);

            var page = new AccountDetailPage(viewModel);

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
