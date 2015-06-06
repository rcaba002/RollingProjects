using ProspectManager.Models;
using ProspectManager.Models.Contacts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProspectManager.Controllers
{
    public class ContactsController : Controller
    {
        DataContext db = new DataContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var contact = db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors");
                return View(contact);
            }

            Contact retreivedContact = db.Contacts.Find(contact.Id);
            retreivedContact.Name = contact.Name;
            retreivedContact.BirthDate = contact.BirthDate;
            retreivedContact.Email = contact.Email;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}