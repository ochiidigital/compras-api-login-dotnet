using ComprasAPI.Data.DTO;
using ComprasAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComprasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        [HttpGet]
        public IActionResult ListaProdutos()
        {
            List<ReadProdutoDTO> dto = produtoService.ListaProdutos();

            if (dto == null)
                return NotFound();

            return Ok(dto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaProdutoPorId(int id)
        {
            ReadProdutoDTO dto = produtoService.RecuperaProdutoPorId(id);

            if (dto == null)
                return NotFound();

            return Ok(dto);
        }

        [HttpPost]
        public IActionResult AdicionaProduto([FromBody]CreateProdutoDTO createProdutoDTO)
        {
            ReadProdutoDTO readProdutoDTO = produtoService.AdicionaProduto(createProdutoDTO);

            return CreatedAtAction(nameof(RecuperaProdutoPorId), 
                new { Id = readProdutoDTO.Id }, readProdutoDTO);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaProduto(int id, [FromBody] UpdateProdutoDTO updateProdutoDTO)
        {
            Result result = produtoService.AtualizaProduto(id, updateProdutoDTO);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaProduto(int id)
        {
            Result result = produtoService.DeletaProduto(id);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
