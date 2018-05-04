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

        public UsersController(IUserRequestHandler userRequestHandler)
        {
            _userRequestHandler = userRequestHandler;
        }

        [HttpGet("{id}")]
        public async Task<User> GetUser(int id)
        {
            return await _userRequestHandler.GetUserAsync(id);
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

        //[HttpGet]
        //public User GetLastLoggedInUser()
        //{
            
        //}
    }
}