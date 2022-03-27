using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
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
        private TokenService tokenService;

        public LoginService(SignInManager<IdentityUser<int>> signInManager, TokenService tokenService)
        {
            this.signInManager = signInManager;
            this.tokenService = tokenService;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var identityResult = signInManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (identityResult.Result.Succeeded)
            {
                var identityUser = signInManager.UserManager.Users.FirstOrDefault(u =>
                    u.NormalizedUserName == request.Username.ToUpper());

                Token token = tokenService.CreateToken(identityUser);

                return Result.Ok().WithSuccess(token.Value);
            }

            return Result.Fail("Falha ao logar usuário.");
        }
    }
}
