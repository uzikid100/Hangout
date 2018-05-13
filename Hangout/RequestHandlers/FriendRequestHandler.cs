using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Repository.Interfaces;
using Hangout.RequestHandlers.Interfaces;

namespace Hangout.RequestHandlers
{
    public class FriendRequestHandler: IFriendRequestHandler
    {
        private IFriendRepository _friendRepo;
        private IUserRepository _userRepo;

        public FriendRequestHandler(IFriendRepository friendRepo, IUserRepository userRepo)
        {
            this._friendRepo = friendRepo;
            this._userRepo = userRepo;
        }

        public async Task<User> AddFriend(int userId, int friendId)
        {

            var user = await _userRepo.GetUserWithFriends(userId);
            var friend = await _userRepo.GetUserAsync(friendId);

            user.Friends.Add(new Friend {Id = userId, UserId = friendId});

            await _userRepo.UnitOfWork.SaveChangesAsync();



            //var friend = await _userRepo.GetUserAsync(friendId);
            //var result = await _friendRepo.AddFriend(userId, friendId, friend);
            //await _friendRepo.UnitOfWork.SaveChangesAsync();

            return friend;
        }

        public void UpdateFriends(Friend[] friends)
        {
            var result = _friendRepo.UpdateFriends(friends);
            _friendRepo.UnitOfWork.SaveChangesAsync();

            var friendsList = result.ToList();

            // Probably inneficient to get all users from DB... should try to use 'include'
            //_userRepo.GetUsers().Where(user => user.Id ==)
        }

        public async Task<List<User>> GetUserFriendsAsync(int userId)
        {
            List<User> friends = new List<User>();
            User user = await _userRepo.GetUserWithFriends(userId);
            foreach (var friend in user.Friends)
            {
                friends.Add(friend.User);
            }
            return friends;
        }
    }
}
