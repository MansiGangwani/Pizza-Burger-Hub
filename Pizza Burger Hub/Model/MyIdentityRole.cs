using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Burger_Hub.Models
{
    public class MyIdentityRole : IdentityUser<Guid>
    {
        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "{0} cannot have more than {1} characters.")]
        public string Decription { get; set; }


    }
}
