using DebtBuddy.Forms.Interfaces;
using DebtBuddy.Forms.Repositories;
using DebtBuddy.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DebtBuddy.Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AccountsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        static AccountRepository database;

        public static AccountRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new AccountRepository(DependencyService.Get<IFileHelper>().GetLocalFilePath("Account.db"));
                }
                return database;
            }
        }
    }
}
