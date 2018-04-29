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

        [HttpGet("{username}")]
        public async Task<User> GetUser(string username)
        {
            return await _userRequestHandler.GetUserAsync(username);
        }
    }
}