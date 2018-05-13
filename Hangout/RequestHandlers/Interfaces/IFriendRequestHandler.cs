using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;

namespace Hangout.RequestHandlers.Interfaces
{
    public interface IFriendRequestHandler
    {
        Task<User> AddFriend(int userId, int friendId);
        void UpdateFriends(Friend[] friends);
        Task<List<User>> GetUserFriendsAsync(int userId);
    }
}
