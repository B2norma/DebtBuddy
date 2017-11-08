using DebtBuddy.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBuddy.Forms.Interfaces.Services
{
    public interface IAccountDataService
    {
        Task<List<Account>> GetAllAccounts();

        Task<Account> GetAccount(int id);

        Task<int> AddAccount(Account account);

        Task<int> UpdateAccount(Account account);

        Task<int> DeleteAccount(Account account);
    }
}
