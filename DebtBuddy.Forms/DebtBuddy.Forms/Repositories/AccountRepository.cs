using DebtBuddy.Forms.Interfaces;
using DebtBuddy.Forms.Interfaces.Repositories;
using DebtBuddy.Forms.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DebtBuddy.Forms.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly SQLiteAsyncConnection _connection;

        public AccountRepository(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Account>().Wait();
        }

        public Task<List<Account>> GetAllAccounts()
        {
            return _connection.Table<Account>().ToListAsync();
        }

        public Task<Account> GetAccount(int id)
        {
            return _connection.Table<Account>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> Insert(Account account)
        {
            return _connection.InsertAsync(account);
        }

        public Task<int> Update(Account account)
        {
            return _connection.UpdateAsync(account);
        }

        public Task<int> Delete(Account account)
        {
            return _connection.DeleteAsync(account);
        }
    }
}
