using ComprasAPI.Data.DTO;
using System;
using System.Collections.Generic;
using ComprasAPI.Data;
using System.Linq;
using ComprasAPI.Models;
using AutoMapper;
using FluentResults;

namespace ComprasAPI.Services
{
    public class ProdutoService
    {
        private CompraDbContext context;
        private IMapper mapper;

        public ProdutoService(CompraDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadProdutoDTO> ListaProdutos()
        {
            List<Produto> produtos = context.Produtos.ToList();

            if (produtos == null)
                return null;

            List<ReadProdutoDTO> dto = mapper.Map<List<ReadProdutoDTO>>(produtos);
            return dto;
        }

        public ReadProdutoDTO RecuperaProdutoPorId(int id)
        {
            Produto produto = context.Produtos.FirstOrDefault(p =>
                p.Id == id);

            if (produto == null)
                return null;

            ReadProdutoDTO dto = mapper.Map<ReadProdutoDTO>(produto);
            return dto;
        }

        public ReadProdutoDTO AdicionaProduto(CreateProdutoDTO dto)
        {
            Produto produto = mapper.Map<Produto>(dto);

            context.Produtos.Add(produto);
            context.SaveChanges();

            return mapper.Map<ReadProdutoDTO>(produto);
        }

        public Result AtualizaProduto(int id, UpdateProdutoDTO updateProdutoDTO)
        {
            Produto produto = context.Produtos.FirstOrDefault(
                p => p.Id == id);

            if (produto == null)
                return Result.Fail("Produto não encontrado.");

            mapper.Map(updateProdutoDTO, produto);
            context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaProduto(int id)
        {
            Produto produto = context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return Result.Fail("Produto não encontrado.");

            context.Produtos.Remove(produto);
            context.SaveChanges();

            return Result.Ok();
        }
    }
}
