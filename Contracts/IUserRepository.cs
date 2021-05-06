using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IUserRepository
    {
        PagedList<User> GetAllUsers(UserParameters userParameters, bool trackChanges);
        User GetUser(Guid Id, bool trackChanges);

        void CreateUser(User user);

        void DeleteUser(User user);
    }
}