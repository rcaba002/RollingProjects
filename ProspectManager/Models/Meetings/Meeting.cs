using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Razor.Text;

namespace ProspectManager.Models.Meetings
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime MeetingDate { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    }
}