using Aplication.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IBaseService<User> _UserService;
        private readonly IMapper _mapper;

        public UserController(IBaseService<User> UserService, IMapper mapper)
        {
            _UserService = UserService;
            _mapper = mapper;
        }

        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            var User = _mapper.Map<User>(request);

            var response = await _UserService.CreateAsync(User, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }



        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(int id, CancellationToken token)
        {
            var UserExist = await _UserService.GetAsync(id);

            if (UserExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleUserResponse>(UserExist);

            return response == null ? NotFound() : Ok(response);
        }


        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var User = await _UserService.GetAllAsync(token);

            var response = new GetAllUserResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleUserResponse>>(User)
            };

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateUserRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            User User = _mapper.Map<User>(request);

            await _UserService.UpdateAsync(User, token);

            var response = _mapper.Map<SingleUserResponse>(User);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
        {
            var response = await _UserService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"User with ID {id} not found.");
        }
    }
}
