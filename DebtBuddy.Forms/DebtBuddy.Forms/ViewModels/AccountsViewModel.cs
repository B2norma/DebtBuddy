using DebtBuddy.Forms.Models;
using DebtBuddy.Forms.Services;
using DebtBuddy.Forms.Services.IServices;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService))]
namespace DebtBuddy.Forms.ViewModels
{
    public class AccountsViewModel : INotifyPropertyChanged
    {
        private INavigationService _navigationService;

        ObservableCollection<Account> _accounts = new ObservableCollection<Account>()
        {
            new Account{Name = "Discover", Balance = 5000, InterestRate = 99.99},
            new Account{Name = "Wells Fargo", Balance = 10000, InterestRate = 9.99},
            new Account{Name = "Best Buy", Balance = 123456.25, InterestRate = 00.09}
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public AccountsViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();

            ShowCreateAccountViewModel = new Command(async() => await _navigationService.NavigateToCreateAccount());
        }

        public Command ShowCreateAccountViewModel { get; }

        public ObservableCollection<Account> Accounts
        {
            get => _accounts;
            set
            {
                _accounts = value;
                OnPropertyChanged("Accounts");
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
