using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.RequestHandlers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hangout.Controllers
{
    [Route("api/Friends")]
    public class FriendsController : Controller
    {
        private IUserRequestHandler _userRequestHandler;
        private IFriendRequestHandler _friendRequestHandler;

        public FriendsController(IUserRequestHandler userRequest, IFriendRequestHandler friendRequest)
        {
            _userRequestHandler = userRequest;
            _friendRequestHandler = friendRequest;
        }

        [HttpGet("{id}")]
        public async Task<List<User>> GetFriends(int userId)
        {
            return await _friendRequestHandler.GetUserFriendsAsync(userId);
        }

        // Need a way to verify the relationship was actually updated
        [HttpPost]
        public async Task<User> AddFriend([FromBody] Friend friend)
        {
            return await _friendRequestHandler.AddFriend(friend.Id, friend.UserId);
        }
    }
}