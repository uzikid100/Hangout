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

        public async Task<User> GetUserAsync(int id)
        { 
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            var result = await _context.Users.AddAsync(user);
            return result.Entity;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }

}
