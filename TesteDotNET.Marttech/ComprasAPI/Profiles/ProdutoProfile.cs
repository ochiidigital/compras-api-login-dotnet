using AutoMapper;
using ComprasAPI.Data.DTO;
using ComprasAPI.Models;

namespace ComprasAPI.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<Produto, ReadProdutoDTO>();
            CreateMap<UpdateProdutoDTO, Produto>();
        }
    }
}
