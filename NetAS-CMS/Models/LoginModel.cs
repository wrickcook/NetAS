using System;
using System.ComponentModel.DataAnnotations;

namespace Umbraco.Web.Models.ContentModel
{
    public class LoginModel
    {
        [Display(Name = "UserName")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}