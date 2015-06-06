using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectManager.Models.Contacts
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
