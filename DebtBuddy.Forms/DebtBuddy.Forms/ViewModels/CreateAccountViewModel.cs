using System.ComponentModel;
using Xamarin.Forms;

namespace DebtBuddy.Forms.ViewModels
{
    public class CreateAccountViewModel : INotifyPropertyChanged
    {
        private string _name;
        private double _balance;
        private double _interestRate;

        public event PropertyChangedEventHandler PropertyChanged;

        public CreateAccountViewModel()
        {
            //Commands
        }

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

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
