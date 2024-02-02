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
    public class BeneficiaryRepository : IRepository<int, Beneficiary>
    {
        readonly RequestTrakerContext _context;

        public BeneficiaryRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Beneficiary> Add(Beneficiary item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Beneficiary> Delete(int key)
        {
            var beneficiary = await GetAsync(key);
            _context?.Beneficiaries.Remove(beneficiary);
            return beneficiary;
        }

        public async Task<Beneficiary> GetAsync(int key)
        {
            var beneficiaries = await GetAsync();
            var beneficiary = beneficiaries.FirstOrDefault(e => e.BeneficiaryID == key);

            if (beneficiary != null)
                return beneficiary;

            throw new NoSuchBeneficiaryException();
        }

        public async Task<List<Beneficiary>> GetAsync()
        {
            var beneficiaries = _context.Beneficiaries.ToList();
            return beneficiaries;
        }

        public async Task<Beneficiary> Update(Beneficiary item)
        {
            var beneficiary = await GetAsync(item.BeneficiaryID);
            _context.Entry<Beneficiary>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
