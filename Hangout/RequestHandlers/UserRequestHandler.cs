using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Repository.Interfaces;
using Hangout.RequestHandlers.Interfaces;

namespace Hangout.RequestHandlers
{
    public class UserRequestHandler: IUserRequestHandler
    {
        private IUserRepository _userRepo;

        public UserRequestHandler(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> GetUserAsync(string username)
        {
            return await _userRepo.GetUserAsync(username);
        }
    }
}
