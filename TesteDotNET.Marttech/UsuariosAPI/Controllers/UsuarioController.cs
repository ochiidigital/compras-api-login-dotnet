using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDTO createUsuarioDTO)
        {
            Result result = usuarioService.CadastraUsuario(createUsuarioDTO);

            if (result.IsFailed)
                return StatusCode(500);

            return Ok();
        }
    }
}
