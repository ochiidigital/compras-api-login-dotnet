using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using UsuariosAPI.Data.DTO;
using UsuariosAPI.Data.Requests;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class LoginService
    {
        //private IMapper mapper;
        //private UserManager<IdentityUser<int>> userManager;

        private SignInManager<IdentityUser<int>> signInManager;

        public LoginService(SignInManager<IdentityUser<int>> signInManager)
        {
            this.signInManager = signInManager;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var identityResult = signInManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (identityResult.Result.Succeeded)
                return Result.Ok();

            return Result.Fail("Falha ao logar usuário.");
        }
    }
}
