using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Extensions
{
    public static class RepositoryUserExtensions
    {
        public static IQueryable<User> Search(this IQueryable<User> users, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return users;
            }

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return users.Where(e => e.FirstName.ToLower().Contains(lowerCaseTerm));
        }
    }
}
