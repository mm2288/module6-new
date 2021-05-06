using Entities.Models;
using Repository.Extensions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace Repository.Extensions
{
    public static class RepositoryOrganizationExtensions
    {
        public static IQueryable<Organization> Sort(this IQueryable<Organization> organizations, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return organizations.OrderBy(e => e.OrgName);
            }

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Organization>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
            {
                return organizations.OrderBy(e => e.OrgName);
            }

            return organizations.OrderBy(orderQuery);
        }
        public static IQueryable<Organization> FilterOrganizations(this IQueryable<Organization> organizations, string filterCity)
        {
            if (string.IsNullOrWhiteSpace(filterCity))
            {
                return organizations;
            }

            var lowerCaseTerm = filterCity.Trim().ToLower();

            return organizations.Where(e => (e.City == lowerCaseTerm));
        }

        public static IQueryable<Organization> Search(this IQueryable<Organization> organizations, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return organizations;
            }

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return organizations.Where(e => e.OrgName.ToLower().Contains(searchTerm));
        }
    }
}
