using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Abstract
{
    public interface ILoginController
    {
        public Task<IActionResult> Login(LoginAppUserDTO loginAppUserDTO);
    }
}
