using ActionFilters;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyEmployees.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "getAllUsers")]
        public IActionResult GetUsers([FromQuery] UserParameters userParameters)
        {
            var users = _repository.User.GetAllUsers(userParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(users.MetaData));

            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return Ok(userDto);
        }

        [HttpGet("{id}", Name = "getUserById")]
        public IActionResult GetUser(Guid id)
        {
            var user = _repository.User.GetUser(id, trackChanges: false); 
            if (user == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var userDto = _mapper.Map<UserDto>(user);
                return Ok(userDto);
            }
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateUserExistsAttribute))]
        public IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDto user)
        {
            var userEntity = HttpContext.Items["user"] as User;

            _mapper.Map(user, userEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateUserExistsAttribute))]
        public IActionResult DeleteUser(Guid id)
        {
            //var user = _repository.User.GetUser(id, trackChanges: false);
            var user = HttpContext.Items["user"] as User;

            _repository.User.DeleteUser(user);
            _repository.Save();

            return NoContent();
        }

        
    }
}