using DebtBuddy.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBuddy.Forms.Interfaces.Repositories
{
    interface IAccountRepository
    {
        Task<List<Account>> GetAllAccounts();

        Task<Account> GetAccount(int id);

        Task<int> Insert(Account account);

        Task<int> Update(Account account);

        Task<int> Delete(Account account);
    }
}
