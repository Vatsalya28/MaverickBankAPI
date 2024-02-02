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
    public class BankRepository : IRepository<int, Bank>
    {
        readonly RequestTrakerContext _context;

        public BankRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Bank> Add(Bank item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Bank> Delete(int key)
        {
            var bank = await GetAsync(key);
            _context?.Banks.Remove(bank);
            return bank;
        }

        public async Task<Bank> GetAsync(int key)
        {
            var banks = await GetAsync();
            var bank = banks.FirstOrDefault(e => e.BankID == key);

            if (bank != null)
                return bank;

            throw new NoSuchBankException();
        }

        public async Task<List<Bank>> GetAsync()
        {
            var banks = _context.Banks.ToList();
            return banks;
        }

        public async Task<Bank> Update(Bank item)
        {
            var bank = await GetAsync(item.BankID);
            _context.Entry<Bank>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
