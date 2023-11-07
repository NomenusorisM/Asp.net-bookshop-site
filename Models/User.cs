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
    public bool HasPurchases { get; set; }
}

