using SimpleContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SImpleContactManagerTests
{
    public class MainViewModelTest
    {
        [Fact]
        public void RemoveContactAction_RemovesSelectedItemFromList()
        {
            MainViewModel model = new MainViewModel();
            Contact contact1 = new Contact();
            Contact contact2 = new Contact();

            model.Contacts.Clear();
            model.Contacts.Add(contact1);
            model.Contacts.Add(contact2);
            model.SelectedContact = contact1;

            model.DeleteContactAction();

            Assert.DoesNotContain(contact1, model.Contacts);
        }
    }
}
