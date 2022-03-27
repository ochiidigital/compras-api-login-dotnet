using ComprasAPI.Data.DTO;
using ComprasAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComprasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        private CarrinhoService carrinhoService;

        public CarrinhoController(CarrinhoService carrinhoService)
        {
            this.carrinhoService = carrinhoService;
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult ListaCarrinhos()
        {
            List<ReadCarrinhoDTO> readCarrinhoDTOs = carrinhoService
                .ListaCarrinhos();

            if (readCarrinhoDTOs == null)
                return NotFound();

            return Ok(readCarrinhoDTOs);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin, cliente")]
        public IActionResult RecuperaCarrinhoPorId(int id)
        {
            ReadCarrinhoDTO dto = carrinhoService.RecuperaCarrinhoPorId(id);

            if (dto == null)
                return NotFound();

            return Ok(dto);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaCarrinho([FromBody] CreateCarrinhoDTO createCarrinhoDTO)
        {
            ReadCarrinhoDTO readCarrinhoDTO = carrinhoService.AdicionaCarrinho(createCarrinhoDTO);

            return CreatedAtAction(nameof(RecuperaCarrinhoPorId),
                new { Id = readCarrinhoDTO.Id }, readCarrinhoDTO);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin, cliente")]
        public IActionResult AtualizaCarrinho(int id, [FromBody] UpdateCarrinhoDTO updateCarrinhoDTO)
        {
            Result result = carrinhoService.AtualizaCarrinho(id, updateCarrinhoDTO);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult DeletaCarrinho(int id)
        {
            Result result = carrinhoService.DeletaCarrinho(id);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
