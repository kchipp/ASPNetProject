using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string  UserName { get; set; }
        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Check if registering as a Customer")]
        public bool Customer { get; set; }
    }

}