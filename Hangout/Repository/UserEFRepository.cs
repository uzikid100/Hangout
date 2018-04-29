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

        public async Task<User> GetUserAsync(string username)
        {
            return await _context.Users.FindAsync(username);
        }
    }
}
