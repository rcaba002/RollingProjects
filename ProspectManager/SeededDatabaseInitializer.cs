using ProspectManager.Models;
using ProspectManager.Models.Contacts;
using ProspectManager.Models.TodoItems;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProspectManager
{

    class SeededDatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);

            context.Contacts.Add(new Contact { Name = "John Doe", Email = "j.doe@example.com", 
                BirthDate = new DateTime(1978, 4, 3)});
            context.Contacts.Add(new Contact { Name = "Jane Doe", Email = "jdoe@example.com", 
                BirthDate = new DateTime(1978, 6, 3)});
            context.Contacts.Add(new Contact { Name = "Superman", Email = "super@example.com", 
                BirthDate = new DateTime(1978, 9, 3)});

            context.TodoItems.Add(new TodoItem { Description = "Do something", DueDate = new DateTime(2015, 1, 1) });
            context.TodoItems.Add(new TodoItem { Description = "Already done", DueDate = new DateTime(2015, 7, 1), Completed = true });
            context.TodoItems.Add(new TodoItem { Description = "Not due ever" });

        }

        //protected override void Seed(DataContext context)
        //{
        //    base.Seed(context);

        //    context.Contacts.Add(new Contact { Name = "Superman", Age = 39 });
        //    context.Contacts.Add(new Contact { Name = "John Doe", Age = 26 });
        //    context.Contacts.Add(new Contact { Name = "Jane Doe", Age = 25 });
        //    context.SaveChanges();
        //}
    }
}