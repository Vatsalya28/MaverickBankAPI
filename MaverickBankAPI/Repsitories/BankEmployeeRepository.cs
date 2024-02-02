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
    public class BankEmployeeRepository : IRepository<int, BankEmployee>
    {
        readonly RequestTrakerContext _context;

        public BankEmployeeRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<BankEmployee> Add(BankEmployee item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<BankEmployee> Delete(int key)
        {
            var bankEmployee = await GetAsync(key);
            _context?.BankEmployees.Remove(bankEmployee);
            return bankEmployee;
        }

        public async Task<BankEmployee> GetAsync(int key)
        {
            var bankEmployees = await GetAsync();
            var bankEmployee = bankEmployees.FirstOrDefault(e => e.EmployeeID == key);

            if (bankEmployee != null)
                return bankEmployee;

            throw new NoSuchBankEmployeeException();
        }

        public async Task<List<BankEmployee>> GetAsync()
        {
            var bankEmployees = _context.BankEmployees.ToList();
            return bankEmployees;
        }

        public async Task<BankEmployee> Update(BankEmployee item)
        {
            var bankEmployee = await GetAsync(item.EmployeeID);
            _context.Entry<BankEmployee>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
