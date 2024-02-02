using MaverickBankAPI.Contexts;
using MaverickBankAPI.Exceptions;
using MaverickBankAPI.Interfaces;
using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaverickBankAPI.Repositories
{
    public class AccountRepository : IRepository<int, Account>
    {
        private readonly RequestTrakerContext _context;

        public AccountRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Account> Add(Account item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Account> Delete(int key)
        {
            var account = await GetAsync(key);
            _context.Accounts.Remove(account);
            _context.SaveChanges();
            return account;
        }

        public async Task<Account> GetAsync(int key)
        {
            var account = await _context.Accounts.FindAsync(key);
            if (account != null)
                return account;

            throw new NoSuchAccountException();
        }

        public async Task<List<Account>> GetAsync()
        {
            var accounts = await _context.Accounts.ToListAsync();
            return accounts;
        }

        public async Task<Account> Update(Account item)
        {
            var account = await GetAsync(item.AccountID);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
