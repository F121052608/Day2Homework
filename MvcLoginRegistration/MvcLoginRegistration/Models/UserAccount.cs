using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcLoginRegistration.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public int FirstName { get; set; }

        [Required(ErrorMessage = "Last is required.")]
        public int LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]                     
        //[RegularExpression(@"^([\w-\.])")]
        public int Email { get; set; }

        [Required(ErrorMessage = "Username Name is required.")]
        public int Username { get; set; }

        [Required(ErrorMessage = "Password Name is required.")]
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [Compare("Password",ErrorMessage = "Please confirm your ConfirmPassword.")]
        [DataType(DataType.Password)]
        public int ConfirmPassword { get; set; }
    }
}