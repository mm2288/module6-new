using ActionFilters;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/organizations")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class OrganizationsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrganizationsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "getAllOrganizations"), Authorize(Roles = "Manager")]
        public IActionResult GetOrganizations()
        {
            var organizations = _repository.Organization.GetAllOrganizations(trackChanges: false);

            var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);
            //uncomment the code below to test the global exception handling
            //throw new Exception("Exception");
            return Ok(organizationDto);
        }

        [HttpGet("{id}", Name = "getOrganizationById")]
        public IActionResult GetOrganization(Guid id)
        {
            var organization = _repository.Organization.GetOrganization(id, trackChanges: false); if (organization == null)
            {
                _logger.LogInfo($"Organization with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var organizationDto = _mapper.Map<OrganizationDto>(organization);
                return Ok(organizationDto);
            }
        }

        [HttpPost(Name = "createOrganization")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult CreateOrganization([FromBody] OrganizationForCreationDto organization)
        {
            var organizationEntity = _mapper.Map<Organization>(organization);

            _repository.Organization.CreateOrganization(organizationEntity);
            _repository.Save();

            var organizationToReturn = _mapper.Map<OrganizationDto>(organizationEntity);

            return CreatedAtRoute("getOrganizationById", new { id = organizationToReturn.Id }, organizationToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateOrganizationExistsAttribute))]
        public IActionResult UpdateOrganization(Guid id, [FromBody] OrganizationForUpdateDto organization)
        {
            //var organizationEntity = _repository.Organization.GetOrganization(id, trackChanges: true);
            var organizationEntity = HttpContext.Items["organization"] as Organization;
            
            _mapper.Map(organization, organizationEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateOrganizationExistsAttribute))]
        public IActionResult DeleteOrganization(Guid id)
        {
            //var organization = _repository.Organization.GetOrganization(id, trackChanges: false);
            var organization = HttpContext.Items["organization"] as Organization;
            
            _repository.Organization.DeleteOrganization(organization);
            _repository.Save();

            return NoContent();
        }
    }
}