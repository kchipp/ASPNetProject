using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPNetProject.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public bool Billing { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required]
        public int ZipCode { get; set; }

              

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}