using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookShop.Models;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    [Required]
    public int Id { get; set; }
    public string UserName { get; set; }
    [PasswordPropertyText]
    public string Password { get; set; }
    [EmailAddress]
    public string Email {  get; set; }
    public DateOnly RegistrationDate { get; set; }
    public bool IsEmailConfirmed { get; set;}
}

