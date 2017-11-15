using DebtBuddy.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Interfaces.Services
{
    public interface INavigationService
    {
        Task PopAsync();

        Task NavigateToCreateAccount();

        Task NavigateToAccountDetail(Account account);
    }
}
