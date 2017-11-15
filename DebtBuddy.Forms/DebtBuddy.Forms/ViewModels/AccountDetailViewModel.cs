using DebtBuddy.Forms.Interfaces.Services;
using DebtBuddy.Forms.Models;
using DebtBuddy.Forms.Services;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService))]
[assembly: Dependency(typeof(AccountDataService))]
namespace DebtBuddy.Forms.ViewModels
{
    public class AccountDetailViewModel
    {
        private INavigationService _navigationService;
        private IAccountDataService _accountDataService;

        public event PropertyChangedEventHandler PropertyChanged;

        public AccountDetailViewModel(Account account)
        {
            _navigationService = DependencyService.Get<INavigationService>();
            _accountDataService = DependencyService.Get<IAccountDataService>();

            _account = account;

            ProcessAccountPurchaseThenShowAccountsViewModel = new Command(async() => await ProcessAccountPurchase());
            ProcessAccountPaymentThenShowAccountsViewModel = new Command(async() => await ProcessAccountPayment());
            DeleteAccountThenShowAccountsViewModel = new Command(async () => await DeleteAccount());
            SaveChanges = new Command(async () => await _accountDataService.UpdateAccount(_account));
        }

        public Command ProcessAccountPurchaseThenShowAccountsViewModel { get; }
        public Command ProcessAccountPaymentThenShowAccountsViewModel { get; }
        public Command DeleteAccountThenShowAccountsViewModel { get; }
        public Command SaveChanges { get; }

        private Account _account;

        public Account Account
        {
            get => _account;
            set
            {
                if (value != _account)
                {
                    _account = value;

                    OnPropertyChanged("Account");
                }
            }
        }

        private double _amount;

        public double Amount
        {
            get => _amount;
            set
            {
                if (value != _amount)
                {
                    _amount = value;

                    OnPropertyChanged("Amount");
                }
            }
        }

        private async Task ProcessAccountPurchase()
        {
            _account.Balance += _amount;

            await _accountDataService.UpdateAccount(_account);

            await _navigationService.PopAsync();
        }

        private async Task ProcessAccountPayment()
        {
            _account.Balance -= _amount;

            await _accountDataService.UpdateAccount(_account);

            await _navigationService.PopAsync();
        }

        private async Task DeleteAccount()
        {
            await _accountDataService.DeleteAccount(_account);

            await _navigationService.PopAsync();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if(propertyName.Equals("Account"))
            {
                _accountDataService.UpdateAccount(_account);
            }
        }
    }
}
