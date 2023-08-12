using AutoMapper;
using Casgem_APILayer.Abstract;
using Casgem_CoreLayer.CommonMessages.Constants;
using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase, IRegisterController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(CreateAppUserDTO createAppUserDTO)
        {
            AppUser appUser = _mapper.Map<AppUser>(createAppUserDTO);
            var result = await _userManager.CreateAsync(appUser, createAppUserDTO.Password);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("username", createAppUserDTO.Username);
                return Ok(Messages.RegisterSuccessfully);
            }
            return BadRequest(Messages.RegisterFail);
            //return Response<string>.Success("Test", 200);
        }
    }
}