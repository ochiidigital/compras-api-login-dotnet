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
    public class ClienteService
    {
        private CompraDbContext context;
        private IMapper mapper;

        public ClienteService(IMapper mapper, CompraDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public List<ReadClienteDTO> ListaClientes()
        {
            List<Cliente> clientes = context.Clientes.ToList();

            if (clientes == null)
                return null;

            List<ReadClienteDTO> readClienteDTOs = mapper.Map<List<ReadClienteDTO>>(clientes);  
            return readClienteDTOs;
        }

        public ReadClienteDTO RecuperaClientePorId(int id)
        {
            Cliente cliente = context.Clientes.FirstOrDefault(
                c => c.Id == id);

            if (cliente == null)
                return null;

            ReadClienteDTO readClienteDTO = mapper.Map<ReadClienteDTO>(cliente);
            return readClienteDTO;
        }

        public ReadClienteDTO AdicionaCliente(CreateClienteDTO dto)
        {
            Cliente cliente = mapper.Map<Cliente>(dto);

            context.Clientes.Add(cliente);
            context.SaveChanges();

            return mapper.Map<ReadClienteDTO>(cliente);
        }

        public Result AtualizaCliente(int id, UpdateClienteDTO updateClienteDTO)
        {
            Cliente cliente = context.Clientes.FirstOrDefault(
                c => c.Id == id);

            if (cliente == null)
                return Result.Fail("Cliente não encontrado.");

            mapper.Map(updateClienteDTO, cliente);
            context.SaveChanges();

            return Result.Ok();
        }

        public Result DeletaCliente(int id)
        {
            Cliente cliente = context.Clientes.FirstOrDefault(
                c => c.Id == id);

            if (cliente == null)
                return Result.Fail("Cliente não encontrado.");

            context.Clientes.Remove(cliente);
            context.SaveChanges();

            return Result.Ok();
        }
    }
}
