using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleContactManager
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Contacts = new ObservableCollection<Contact>(new [] {
                new Contact("John Doe", "jdoe@example.com", "314-555-1234", "123 Main"),
                new Contact("Jane Doe", "jadoe@example.com", "314-555-3122", "345 Main"),
                new Contact("Andrew Benz", "andorbal@gmail.com", "", ""),
                new Contact("Superman", "superman@example.com", "314-555-1235", "Fortress of Solitude")
            });
        }

        public ObservableCollection<Contact> Contacts { get; set; }

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get
            {
                return selectedContact;
            }
            set
            {
                Set(() => SelectedContact, ref selectedContact, value);
            }
        }
    }
}
