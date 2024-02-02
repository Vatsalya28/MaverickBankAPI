using MaverickBankAPI.Contexts;
using MaverickBankAPI.Exceptions;
using MaverickBankAPI.Interfaces;
using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaverickBankAPI.Repsitories
{
    public class LoanRepository : IRepository<int, Loan>
    {
        readonly RequestTrakerContext _context;
        public LoanRepository(RequestTrakerContext context)
        {
            _context = context;
        }
        public async  Task<Loan> Add(Loan item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Loan> Delete(int key)
        {
            var loan = await GetAsync(key);
            _context?.Loans.Remove(loan);
            return loan;
        }

        public async Task<Loan> GetAsync(int key)
        {
            var loans = await GetAsync();
            var loan = loans.FirstOrDefault(e => e.LoanID == key);
            if (loan != null)
                return loan;
            throw new NoSuchLoanException();
        }

        public async Task<List<Loan>> GetAsync()
        {
            var loans = _context.Loans.ToList();
            return loans;
        }

        public async Task<Loan> Update(Loan item)
        {
            var loan = await GetAsync(item.LoanID);
            _context.Entry<Loan>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
