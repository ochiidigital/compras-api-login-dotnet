using AutoMapper;
using ComprasAPI.Data.DTO;
using ComprasAPI.Models;

namespace ComprasAPI.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDTO, Cliente>();
            CreateMap<Cliente, ReadClienteDTO>();
            CreateMap<UpdateClienteDTO, Cliente>();
        }
    }
}
