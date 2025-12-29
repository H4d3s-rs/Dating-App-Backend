using System;

namespace API_DatingApp.DTO;

public class UserDTO
{
    public required string Id { get; set; }

    public required string Email { get; set; }

    public required string DisplayName { get; set; }

    public required string Token { get; set; }

    public string? ImageUrl { get; set; }

    
}
