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
    public class LogoutService
    {
        private SignInManager<IdentityUser<int>> signInManager;

        public LogoutService(SignInManager<IdentityUser<int>> signInManager)
        {
            this.signInManager = signInManager;
        }

        public Result DeslogaUsuario()
        {
            var identityResult = signInManager.SignOutAsync();
            if (identityResult.IsCompletedSuccessfully)
                return Result.Ok();

            return Result.Fail("Falha no logout.");
        }
    }
}
