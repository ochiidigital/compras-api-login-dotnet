using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginService loginService;

        public LoginController(LoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
            Result result = loginService.LogaUsuario(request);

            if (result.IsFailed)
                return Unauthorized(result.Errors);

            return Ok(result.Successes);
        }
    }
}
