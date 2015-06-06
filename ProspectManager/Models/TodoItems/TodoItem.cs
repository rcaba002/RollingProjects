using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProspectManager.Models.TodoItems
{
    public class TodoItem
    {
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; }
    }
}