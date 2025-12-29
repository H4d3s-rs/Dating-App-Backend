using System;
using API_DatingApp.DTO;
using API_DatingApp.Entities;
using API_DatingApp.Interfaces;

namespace API_DatingApp.Extensions;

public static class AppUserExtensions
{
    public static UserDTO ToDTO(this AppUser user, ITokenService tokenService)
    {
        return new UserDTO
        {
            Id = user.Id,
            Email = user.Email,
            DisplayName = user.DisplayName,
            Token = tokenService.CreateToken(user)

        };
    }
}
