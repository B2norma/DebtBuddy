using DebtBuddy.Forms.Interfaces;
using DebtBuddy.Forms.Interfaces.Repositories;
using DebtBuddy.Forms.Interfaces.Services;
using DebtBuddy.Forms.Models;
using DebtBuddy.Forms.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Services
{
    public class AccountDataService : IAccountDataService
    {
        private IAccountRepository _accountRepository;

        public AccountDataService()
        {
            _accountRepository = App.Database;
        }

        public Task<List<Account>> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }

        public Task<Account> GetAccount(int id)
        {
            return _accountRepository.GetAccount(id);
        }

        public Task<int> AddAccount(Account account)
        {
            return _accountRepository.Insert(account);
        }

        public Task<int> UpdateAccount(Account account)
        {
            return _accountRepository.Update(account);
        }

        public Task<int> DeleteAccount(Account account)
        {
            return _accountRepository.Delete(account);
        }
    }
}
