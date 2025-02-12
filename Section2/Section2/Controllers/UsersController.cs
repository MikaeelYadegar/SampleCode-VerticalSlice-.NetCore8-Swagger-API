using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Section2.Domain.DTOs.Users;
using Section2.Domain.Entities;
using Section2.Domain.Infrastructure;
using Section2.Domain.Interfaces;

namespace Section2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDTO userDto)
        {
            //_context.Users.Add(user);
            //_context.SaveChanges(); 
            /////////////////////////////////////////
            /////////MAP/////////////////////////////////
            //User user=new User();
            //user.FirstName = userDto.FirstName;
            //user.LastName = userDto.LastName;
            //user.UserName = userDto.UserName;
            //user.NationalCode = userDto.NationalCode; 
            //user.Password=userDto.Password; 
            //user.CreateDate=DateTime.Now;
            var user = userDto.Adapt<User>();
            _userRepository.CreateUser(user);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            var users = _userRepository.GetAllUsers();
            var UserDtoes = users.Adapt<GetUserDto>();
            return Ok(UserDtoes);
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(long id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return BadRequest("کاربر با شناسه ارسالی یافت نشد");
            }
            return Ok(user);
        }
    }
}
