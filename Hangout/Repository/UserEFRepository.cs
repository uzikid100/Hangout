using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Database;
using Hangout.Models;
using Hangout.Models.Infrastructure;
using Hangout.Repository.Interfaces;

namespace Hangout.Repository
{
    public class UserEFRepository: IUserRepository
    {
        private readonly HangoutContext _context;

        public UserEFRepository(HangoutContext context)
        {
            this._context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public User GetUserAsync(string username)
        {
            return _context.Users.SingleOrDefault(user => user.Username == username);
        }

        public async Task<User> AddUserAsync(User user)
        {
            var result = await _context.Users.AddAsync(user);
            return result.Entity;
        }
    }
}
