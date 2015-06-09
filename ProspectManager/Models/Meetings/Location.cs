using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace ProspectManager.Models.Meetings
{
    public class Location
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; } 
    }
}
