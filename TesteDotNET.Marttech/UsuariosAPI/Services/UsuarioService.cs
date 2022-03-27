using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class UsuarioService
    {
        private IMapper mapper;
        private UserManager<IdentityUser<int>> userManager;

        public UsuarioService(IMapper mapper, UserManager<IdentityUser<int>> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public Result CadastraUsuario(CreateUsuarioDTO createUsuarioDTO)
        {
            Usuario usuario = mapper.Map<Usuario>(createUsuarioDTO);
            IdentityUser<int> identityUser = mapper.Map<IdentityUser<int>>(usuario);

            var identityResult = userManager
                .CreateAsync(identityUser, createUsuarioDTO.Password).Result;

            if (identityResult.Succeeded)
                return Result.Ok();

            return Result.Fail("Falha ao cadastrar usuário.");
        }
    }
}
