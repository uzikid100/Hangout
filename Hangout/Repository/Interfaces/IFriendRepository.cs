using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Models.Infrastructure;

namespace Hangout.Repository.Interfaces
{
    public interface IFriendRepository: IRepository<User>
    {
        Task<Friend> AddFriend(int userId, int friendId, User friend);
        IQueryable<Friend> UpdateFriends(Friend[] friends);
    }
}
