using MaverickBankAPI.Contexts;
using MaverickBankAPI.Interfaces;
using MaverickBankAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaverickBankAPI.Repositories
{
    public class UserRepository : IRepository<int, User>
    {
        private readonly RequestTrakerContext _context;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(RequestTrakerContext context, ILogger<UserRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<User> Add(User item)
        {
            _context.Add(item);
            _context.SaveChanges();
            _logger.LogInformation("User added: {@User}", item);
            return item;
        }

        public async Task<User> Delete(int key)
        {
            var user = await GetAsync(key);
            _context?.Users.Remove(user);
            _context.SaveChanges();
            _logger.LogInformation("User deleted: {@User}", user);
            return user;
        }

        public async Task<User> GetAsync(int key)
        {
            var user = await _context.Users.FindAsync(key);
            if (user != null)
            {
                _logger.LogInformation("User retrieved: {@User}", user);
                return user;
            }
            _logger.LogError("User with key {Key} not found", key);
            throw new NoSuchUserException();
        }

        public async Task<List<User>> GetAsync()
        {
            var users = _context.Users.ToList();
            _logger.LogInformation("Retrieved all users: {@Users}", users);
            return users;
        }

        public async Task<User> Update(User item)
        {
            var userToUpdate = await _context.Users.FindAsync(item.UserID);
            if (userToUpdate != null)
            {
                _context.Entry(userToUpdate).CurrentValues.SetValues(item);
                _context.SaveChanges();
                _logger.LogInformation("User updated: {@User}", item);
                return item;
            }
            _logger.LogError("User with key {Key} not found", item.UserID);
            throw new NoSuchUserException();
        }
    }
}
