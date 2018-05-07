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

        public async Task<User> GetUserAsync(int id)
        {
            return await _userRepo.GetUserAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            var result = await _userRepo.AddUserAsync(user);
            await _userRepo.UnitOfWork.SaveChangesAsync();
            return result;
        }

        public List<User> GetUsers()
        {
            return _userRepo.GetUsers();
        }

        public User GetLastLoggedInUser()
        {
            return _userRepo.GetLastLoggedInUser();
        }

        public IQueryable<User> GetUserByUsername(string username)
        {
            return _userRepo.GetUserByUsername(username);
        }

    }
}
