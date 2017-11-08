using DebtBuddy.Forms.Interfaces.Services;
using DebtBuddy.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            await Application.Current.MainPage.Navigation.PushAsync(new CreateAccountPage());
        }
    }
}
