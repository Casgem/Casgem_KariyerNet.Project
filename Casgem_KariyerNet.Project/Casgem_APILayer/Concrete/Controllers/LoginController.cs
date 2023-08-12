using Casgem_APILayer.Abstract;
using Casgem_CoreLayer.CommonMessages.Constants;
using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase, ILoginController
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginAppUserDTO loginAppUserDTO)
        {
            string username = loginAppUserDTO.Username;
            string password = loginAppUserDTO.Password;
            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("username", username);
                return Ok(Messages.LoginSuccessfully);
            }
            return BadRequest(Messages.LoginFail);
        }
    }
}
