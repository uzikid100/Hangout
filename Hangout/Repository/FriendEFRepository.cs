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
    public class FriendEFRepository: IFriendRepository
    {
        private readonly HangoutContext _context;
        public FriendEFRepository(HangoutContext context)
        {
            this._context = context;    
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<Friend> AddFriend(int userId, int friendId, User friend)
        {

            var result = await _context.Friends.AddAsync(new Friend() { Id = userId, UserId = friendId, User = friend});
            return result.Entity;
        }

        public IQueryable<Friend> UpdateFriends(Friend[] friends)
        {
            _context.Friends.UpdateRange(friends);

            // Can get 0 index because we are updating friends list for a single user
            return _context.Friends.Where(f => f.Id == friends[0].Id);
        }

    }
}
