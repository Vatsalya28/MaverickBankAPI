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
    public class AdministratorRepository : IRepository<int, Administrator>
    {
        readonly RequestTrakerContext _context;

        public AdministratorRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Administrator> Add(Administrator item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Administrator> Delete(int key)
        {
            var administrator = await GetAsync(key);
            _context?.Administrators.Remove(administrator);
            return administrator;
        }

        public async Task<Administrator> GetAsync(int key)
        {
            var administrators = await GetAsync();
            var administrator = administrators.FirstOrDefault(e => e.AdministratorID == key);

            if (administrator != null)
                return administrator;

            throw new NoSuchAdministratorException();
        }

        public async Task<List<Administrator>> GetAsync()
        {
            var administrators = _context.Administrators.ToList();
            return administrators;
        }

        public async Task<Administrator> Update(Administrator item)
        {
            var administrator = await GetAsync(item.AdministratorID);
            _context.Entry<Administrator>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}
