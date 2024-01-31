using AutoMapper;
using Dating_APP.Data;
using Dating_APP.DTOs;
using Dating_APP.Entities;
using Dating_APP.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dating_APP.Controllers
{

    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> Get()
        {
            var users = await _repository.GetUserAsync();
            var usersToReturn = _mapper.Map<IEnumerable<MemberDTO>>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MemberDTO>> GetUser(int id)
        {
            var users = await _repository.GetUserByIDAsync(id);
            var usersToReturn = _mapper.Map<MemberDTO>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<MemberDTO>> GetUser(string name)
        {
            var users = await _repository.GetUserByNameAsync(name);
            var usersToReturn = _mapper.Map<MemberDTO>(users);
            return Ok(usersToReturn);
        }


    }
}
