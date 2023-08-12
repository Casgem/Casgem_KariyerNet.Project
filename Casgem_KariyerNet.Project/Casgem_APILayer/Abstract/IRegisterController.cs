using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Abstract
{
    public interface IRegisterController
    {
        public Task<IActionResult> UserRegister(CreateAppUserDTO createAppUserDTO);
    }
}
