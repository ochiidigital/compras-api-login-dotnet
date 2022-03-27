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
        private RoleManager<IdentityRole<int>> roleManager;

        public UsuarioService(IMapper mapper, UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public Result CadastraUsuario(CreateUsuarioDTO createUsuarioDTO)
        {
            Usuario usuario = mapper.Map<Usuario>(createUsuarioDTO);
            IdentityUser<int> identityUser = mapper.Map<IdentityUser<int>>(usuario);

            var identityResult = userManager
                .CreateAsync(identityUser, createUsuarioDTO.Password).Result;
            var createRoleResult = roleManager
                .CreateAsync(new IdentityRole<int>("admin")).Result;
            var usuarioRoleResult = userManager
                .AddToRoleAsync(identityUser, "admin").Result;

            if (identityResult.Succeeded)
                return Result.Ok();

            return Result.Fail("Falha ao cadastrar usuário.");
        }
    }
}
