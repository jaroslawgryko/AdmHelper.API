using System.Threading.Tasks;
using AdmHelper.API.Data;
using AdmHelper.API.Dtos;
using AdmHelper.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdmHelper.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserForRegisterDto userForRegisterDto)
        {            
            if (!string.IsNullOrEmpty(userForRegisterDto.Username))
                userForRegisterDto.Username = userForRegisterDto.Username.ToLower();
            if (await _repo.UserExists(userForRegisterDto.Username))
                ModelState.AddModelError("username", "Już istnieje");
 
            // validate request
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };

            var userCreated = await _repo.Register(userToCreate, userForRegisterDto.Password);
            return StatusCode(201);
        }        
    }
}