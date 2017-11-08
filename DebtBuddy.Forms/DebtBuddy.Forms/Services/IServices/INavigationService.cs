using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Services.IServices
{
    public interface INavigationService
    {
        Task PopAsync();

        Task NavigateToCreateAccount();
    }
}
