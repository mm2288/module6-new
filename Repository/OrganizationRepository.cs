using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class OrganizationRepository : RepositoryBase<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public PagedList<Organization> GetAllOrganizations(OrganizationParameters organizationParameters, bool trackChanges)
        {
            var organizations = FindAll(trackChanges)
                .FilterOrganizations(organizationParameters.FilterCity)
                .Search(organizationParameters.SearchTerm)
                .OrderBy(c => c.OrgName)
                .ToList();

            return PagedList<Organization>.ToPagedList(organizations, organizationParameters.PageNumber, organizationParameters.PageSize);
        }
          
        public Organization GetOrganization(Guid companyId, bool trackChanges) =>
         FindByCondition(c => c.Id.Equals(companyId), trackChanges)
        .SingleOrDefault();

        public void CreateOrganization(Organization organization) => Create(organization);

        public IEnumerable<Organization> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();

        public void DeleteOrganization(Organization organization)
        {
            Delete(organization);
        }
    }
}