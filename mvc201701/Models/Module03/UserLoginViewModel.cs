using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc201701.Models.Module03
{
    public class UserLoginViewModel
    {
        //[Display(Name ="Name of user!")]
        [Display(Name="Username", ResourceType = typeof(mvc201701.Resources.Views.Module03.login))]
        [Required]
        [StringLength(10, ErrorMessage = "Error in length", MinimumLength = 4)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}