﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();
            CreateMap<UpdateUsuarioDTO, Usuario>();
        }
    }
}
