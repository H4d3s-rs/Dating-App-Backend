using System;
using API_DatingApp.Entities;

namespace API_DatingApp.Interfaces;

public interface ITokenService
{
    public string CreateToken(AppUser user);

}
