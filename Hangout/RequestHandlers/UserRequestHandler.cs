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

        public User GetUserAsync(string username)
        {
            return _userRepo.GetUserAsync(username);
        }

        public async Task<User> AddUserAsync(User user)
        {
            var result = await _userRepo.AddUserAsync(user);
            return result;
        }

    }
}
