using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public PagedList<User> GetAllUsers(UserParameters userParameters, bool trackChanges)
        {
            var users = FindAll(trackChanges)
            .OrderBy(c => c.UserName)
            .ToList();

            return PagedList<User>.ToPagedList(users, userParameters.PageNumber, userParameters.PageSize);
        }
          
        public User GetUser(Guid Id, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(Id), trackChanges)
        .SingleOrDefault();

        public void CreateUser(User user) => Create(user);

        /*public IEnumerable<User> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.UserId), trackChanges)
            .ToList();*/

        public void DeleteUser(User user)
        {
            Delete(user);
        }
    }
}