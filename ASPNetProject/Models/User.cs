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
        public string  UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Customer { get; set; }
    }

}