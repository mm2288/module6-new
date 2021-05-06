using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IOrganizationRepository
    {
        PagedList<Organization> GetAllOrganizations(OrganizationParameters organizationParameters, bool trackChanges);

        Organization GetOrganization(Guid companyId, bool trackChanges);

        void CreateOrganization(Organization organization);

        IEnumerable<Organization> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteOrganization(Organization organization);
    }
}