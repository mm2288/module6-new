﻿using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User GetUser(Guid Id, bool trackChanges);

        void CreateUser(User user);

        void DeleteUser(User user);
    }
}