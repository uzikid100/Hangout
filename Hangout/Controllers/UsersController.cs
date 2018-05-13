using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.RequestHandlers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hangout.Controllers
{
    // [Produces(application/Json)]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IUserRequestHandler _userRequestHandler;
        private IFriendRequestHandler _friendRequestHandler;

        public UsersController(IUserRequestHandler userRequestHandler, IFriendRequestHandler friendRequest)
        {
            _userRequestHandler = userRequestHandler;
            _friendRequestHandler = friendRequest;
        }

        [HttpPost]
        public async Task<User> AddNewUser([FromBody] User user)
        {
            return await _userRequestHandler.AddUserAsync(user);
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _userRequestHandler.GetUsers();
        }

        [HttpGet("{username}")]
        public User GetUserByUsername(string username)
        {

            return _userRequestHandler.GetUserByUsername(username);
        }

        [HttpGet("{userId}/friends")]
        public async Task<List<User>> GetFriends(int userId)
        {
            return await _friendRequestHandler.GetUserFriendsAsync(userId);
        }
    }
}