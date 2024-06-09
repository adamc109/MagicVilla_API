using MagicVilla_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Villa_VillaAPI.Models;
using Villa_VillaAPI.Models.DTO;
using Villa_VillaAPI.Repository.IRepository;

namespace Villa_VillaAPI.Controllers
{
    [Route("api/UsersAuth")]
    [ApiController]
    public class UsersController : Controller
    {

        private readonly IUserRepository _userRepo;
        protected APIResponse _response;

        public UsersController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
            this._response = new();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            var LoginResponse = await _userRepo.Login(model);
            if (LoginResponse.User == null || string.IsNullOrEmpty(LoginResponse.Token))
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Username or password is incorrect");
                return BadRequest(_response);
            }

            _response.statusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = LoginResponse;
            return Ok(_response);

        }

        [HttpPost("register")]
        public async Task<IActionResult> Resister([FromBody] RegisterationRequestDTO model)
        {
            bool ifUserNameUnique = _userRepo.IsUniqueUser(model.UserName);
            if (!ifUserNameUnique)
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Username already exists");
                return BadRequest(_response);
            }

            var user = await _userRepo.Register(model);
            if (user == null) 
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Error while registering");
                return BadRequest(_response);
            }
            _response.statusCode = HttpStatusCode.OK;
            _response.IsSuccess=true;
            return Ok(_response);

        }
    }
}
