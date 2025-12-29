using System;
using System.ComponentModel.DataAnnotations;

namespace API_DatingApp.DTO;

public class RegisterDTO
{
    [Required]
    public required string DisplayName { get; set; } = "";

    [Required]
    [EmailAddress]
    public required string Email { get; set; } = "";

    [Required]
    [MinLength(4)]
    public required string Password { get; set; } = "";
  
}
