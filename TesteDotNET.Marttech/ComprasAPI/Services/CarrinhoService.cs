using AutoMapper;
using ComprasAPI.Data;
using ComprasAPI.Data.DTO;
using ComprasAPI.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasAPI.Services
{
    public class CarrinhoService
    {
        private CompraDbContext context;
        private IMapper mapper;

        public CarrinhoService(CompraDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public List<ReadCarrinhoDTO> ListaCarrinhos()
        {
            List<Carrinho> carrinhos = context.Carrinhos.ToList();

            if (carrinhos == null)
                return null;

            List<ReadCarrinhoDTO> readCarrinhoDTOs = mapper
                .Map<List<ReadCarrinhoDTO>>(carrinhos);
            return readCarrinhoDTOs;
        }

        public ReadCarrinhoDTO RecuperaCarrinhoPorId(int id)
        {
            Carrinho carrinho = context.Carrinhos.FirstOrDefault(
                c => c.Id == id);

            if (carrinho == null)
                return null;

            ReadCarrinhoDTO dto = mapper.Map<ReadCarrinhoDTO>(carrinho);    
            return dto;
        }

        public ReadCarrinhoDTO AdicionaCarrinho(CreateCarrinhoDTO createCarrinhoDTO)
        {
            Carrinho carrinho = mapper.Map<Carrinho>(createCarrinhoDTO);

            context.Carrinhos.Add(carrinho);
            context.SaveChanges();

            return mapper.Map<ReadCarrinhoDTO>(carrinho);
        }

        public Result AtualizaCarrinho(int id, UpdateCarrinhoDTO updateCarrinhoDTO)
        {
            Carrinho carrinho = context.Carrinhos.FirstOrDefault(
                c => c.Id == id);

            if (carrinho == null)
                return Result.Fail("Carrinho não encontrado");

            mapper.Map(updateCarrinhoDTO, carrinho);
            context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaCarrinho(int id)
        {
            Carrinho carrinho = context.Carrinhos.FirstOrDefault(
                c => c.Id == id);

            if (carrinho == null)
                return Result.Fail("Carrinho não encontrado.");

            context.Carrinhos.Remove(carrinho);
            context.SaveChanges();

            return Result.Ok();
        }
    }
}
