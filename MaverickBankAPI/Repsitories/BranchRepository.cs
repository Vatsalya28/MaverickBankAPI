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
    public class BranchRepository : IRepository<string, Branch>
    {
        private readonly RequestTrakerContext _context;

        public BranchRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Branch> Add(Branch item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Branch> Delete(string key)
        {
            var branch = await GetAsync(key);
            _context.Branches.Remove(branch);
            await _context.SaveChangesAsync();
            return branch;
        }

        public async Task<Branch> GetAsync(string key)
        {
            var branch = await _context.Branches.FindAsync(key);
            if (branch != null)
                return branch;

            throw new NoSuchBranchException();
        }

        public async Task<List<Branch>> GetAsync()
        {
            var branches = await _context.Branches.ToListAsync();
            return branches;
        }

        public async Task<Branch> Update(Branch item)
        {
            var branch = await GetAsync(item.IFSCCode);
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
