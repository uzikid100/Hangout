using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;

namespace Hangout.RequestHandlers.Interfaces
{
    public interface IUserRequestHandler
    {
        Task<User> GetUserAsync(int id);
        Task<User> AddUserAsync(User user);
        List<User> GetUsers();
        User GetLastLoggedInUser();
    }
}
