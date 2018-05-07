using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Models.Infrastructure;

namespace Hangout.Repository.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserAsync(int id);
        Task<User> AddUserAsync(User user);
        List<User> GetUsers();
        User GetLastLoggedInUser();
        IQueryable<User> AddFriend(int id);

        IQueryable<User> GetUserByUsername(string username);
    }
}
