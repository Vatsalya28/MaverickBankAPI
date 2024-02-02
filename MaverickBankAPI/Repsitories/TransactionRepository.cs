using MaverickBankAPI.Contexts;
using MaverickBankAPI.Exceptions;
using MaverickBankAPI.Interfaces;
using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaverickBankAPI.Repositories
{
    public class TransactionRepository : IRepository<int, Transaction>
    {
        private readonly RequestTrakerContext _context;

        public TransactionRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Transaction> Add(Transaction item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Transaction> Delete(int key)
        {
            var transaction = await GetAsync(key);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<Transaction> GetAsync(int key)
        {
            var transaction = await _context.Transactions.FindAsync(key);
            if (transaction != null)
                return transaction;

            throw new NoSuchTransactionException();
        }

        public async Task<List<Transaction>> GetAsync()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return transactions;
        }

        public async Task<Transaction> Update(Transaction item)
        {
            var transaction = await GetAsync(item.TransactionID);
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
