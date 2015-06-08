using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProspectManager.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
