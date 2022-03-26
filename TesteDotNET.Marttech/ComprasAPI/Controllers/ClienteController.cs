using ComprasAPI.Data.DTO;
using ComprasAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComprasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteService clienteService;

        public ClienteController(ClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult ListaClientes()
        {
            List<ReadClienteDTO> dto = clienteService.ListaClientes();

            if (dto == null)
                return NotFound();

            return Ok(dto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaClientePorId(int id)
        {
            ReadClienteDTO dto = clienteService.RecuperaClientePorId(id);

            if (dto == null)
                return NotFound();

            return Ok(dto);
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] CreateClienteDTO createClienteDTO)
        {
            ReadClienteDTO readClienteDTO= clienteService.AdicionaCliente(createClienteDTO);

            return CreatedAtAction(nameof(RecuperaClientePorId),
                new { Id = readClienteDTO.Id }, readClienteDTO);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, [FromBody] UpdateClienteDTO updateClienteDTO)
        {
            Result result = clienteService.AtualizaCliente(id, updateClienteDTO);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            Result result = clienteService.DeletaCliente(id);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
