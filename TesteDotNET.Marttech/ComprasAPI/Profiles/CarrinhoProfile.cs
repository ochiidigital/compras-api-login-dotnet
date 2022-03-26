using AutoMapper;
using ComprasAPI.Data.DTO;
using ComprasAPI.Models;

namespace ComprasAPI.Profiles
{
    public class CarrinhoProfile : Profile
    {
        public CarrinhoProfile()
        {
            CreateMap<CreateCarrinhoDTO, Carrinho>();
            CreateMap<Carrinho, ReadCarrinhoDTO>();
            CreateMap<UpdateCarrinhoDTO, Carrinho>();
        }
    }
}
