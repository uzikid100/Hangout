﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Models.Infrastructure;

namespace Hangout.Repository.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserAsync(string username);
    }
}