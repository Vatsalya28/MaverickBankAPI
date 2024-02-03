using System;
using MaverickBankAPI.Contexts;
using MaverickBankAPI.Interfaces;
using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;
using MaverickBankAPI.Exceptions;

namespace MaverickBankAPI.Repsitories
{
	public class CustomerRepository:IRepository<int,Customer>
	{
        private readonly RequestTrakerContext _context;

        public CustomerRepository(RequestTrakerContext context)
        {
            _context = context;
        }

        public async Task<Customer> Add(Customer item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Customer> Delete(int key)
        {
            var customer = await GetAsync(key);
            _context?.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }

        public async Task<Customer> GetAsync(int key)
        {
            var customers = await GetAsync();
            var customer = customers.FirstOrDefault(e => e.CustomerID == key);
            if (customer!= null)
                return customer;
            throw new NoSuchCustomerException();
        }

        public async Task<List<Customer>> GetAsync()
        {
            var customers = _context.Customers.Include(u => u.User).ToList();
            return customers;
        }

        public async Task<Customer> Update(Customer item)
        {
            var customer = await GetAsync(item.CustomerID);
            _context.Entry<Customer>(item).State = EntityState.Modified;
            _context.SaveChanges();
            return item;
        }
    }
}

