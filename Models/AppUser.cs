using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

public class AppUser : IdentityUser
{

}

public class CreateUser
{
  [Required]
  public string Name { get; set; }
  [Required]
  public string Email { get; set; }
  [Required]
  public string Password { get; set; }
}
