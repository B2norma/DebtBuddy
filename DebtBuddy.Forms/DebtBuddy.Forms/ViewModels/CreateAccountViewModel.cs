using DebtBuddy.Forms.Interfaces.Services;
using DebtBuddy.Forms.Models;
using DebtBuddy.Forms.Services;
using System.ComponentModel;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService))]
[assembly: Dependency(typeof(AccountDataService))]
namespace DebtBuddy.Forms.ViewModels
{
    public class CreateAccountViewModel : INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        private IAccountDataService _accountDataService;

        public event PropertyChangedEventHandler PropertyChanged;

        public CreateAccountViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            _accountDataService = DependencyService.Get<IAccountDataService>();

            AddAccountToDatabaseCommand = new Command(() => AddAccountToDatabase());
        }

        public Command AddAccountToDatabaseCommand { get; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;

                    OnPropertyChanged("Name");
                }
            }
        }

        private double _balance;
        public double Balance
        {
            get => _balance;
            set
            {
                if (value != _balance)
                {
                    _balance = value;

                    OnPropertyChanged("Balance");
                }
            }
        }

        private double _interestRate;
        public double InterestRate
        {
            get => _interestRate;
            set
            {
                if (value != _interestRate)
                {
                    _interestRate = value;

                    OnPropertyChanged("InterestRate");
                }
            }
        }

        void AddAccountToDatabase()
        {
            _accountDataService.AddAccount(new Account { Name = Name, Balance = Balance, InterestRate = InterestRate });

            _navigationService.PopAsync();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
