﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Database;
using Hangout.Models;
using Hangout.Models.Infrastructure;
using Hangout.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hangout.Repository
{
    public class UserEFRepository: IUserRepository
    {
        private readonly HangoutContext _context;

        public UserEFRepository(HangoutContext context)
        {
            this._context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<User> GetUserAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserWithFriends(int id)
        {
            return await _context.Users.Where<User>(user => user.Id == id)
                .Include(user => user.Friends)
                .FirstOrDefaultAsync();
        }

        public async Task<User> AddUserAsync(User user)
        {
            var result = await _context.Users.AddAsync(user);
            return result.Entity;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetLastLoggedInUser()
        {
            throw new NotImplementedException();
            //var val = _context.Users.Count();
            //return _context.Users.Find(val - 1);
        }

        public IQueryable<User> AddFriend(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.SingleOrDefault<User>(user => user.Username == username);

        }

        public ICollection<Friend> GetFriends(int userId)
        {
            var result = _context.Users.Where(user => user.Id == userId)
                .Include(u => u.Friends)
                .FirstOrDefault();
            return result.Friends;
        } 
    }

}
