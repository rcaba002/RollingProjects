using ProspectManager.Models.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProspectManager.Controllers
{
    public class ContactsController : Controller
    {
        private static Dictionary<int, Contact> contacts =
            new Dictionary<int, Contact>
            {
                {1, new Contact { Name = "John Doe", Email = "j.doe@example.com", BirthDate = new DateTime(1978, 4, 3), Id = 1}},
                {2, new Contact { Name = "Jane Doe", Email = "jdoe@example.com", BirthDate = new DateTime(1978, 6, 3), Id = 2}},
                {3, new Contact { Name = "Superman", Email = "super@example.com", BirthDate = new DateTime(1978, 9, 3), Id = 3}}
            };

        // GET: Contact
        public ActionResult Index()
        {
            return View(contacts.Values.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var contact = contacts[id];
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            contacts[contact.Id] = contact;
            return RedirectToAction("Index");
        }
    }
}