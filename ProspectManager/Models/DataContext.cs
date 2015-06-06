using ProspectManager.Models.Contacts;
using ProspectManager.Models.TodoItems;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProspectManager.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.SetInitializer<DataContext>(new SeededDatabaseInitializer());
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}