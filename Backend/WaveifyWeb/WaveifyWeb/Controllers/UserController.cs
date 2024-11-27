using Microsoft.AspNetCore.Mvc;
using Waveify.API.Contracts;
using Waveify.Application.Interface.Repositiories;
using Waveify.Application.Services;
using Waveify.Core.Models;
namespace Waveify.API.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userServices;
        public UserController(IUserRepository userServices)
        {
            _userServices = userServices;
        }
        //[HttpPost]
        //public async Task<ActionResult<Guid>> RegisterUser([FromBody] RegisterUserRequest RUrequest)
        //{
        //    //var (user, error) = User.Create(
        //    //    Guid.NewGuid(),
        //    //    RUrequest.UserName,
        //    //    RUrequest.Email,
        //    //    RUrequest.Password);
        //    //if (!string.IsNullOrEmpty(error))
        //    //{
        //    //    return BadRequest(error);
        //    //}
        //    //var userId = await _userServices.Add(user);
        //    //return Ok(userId);
        //}

    }
}


