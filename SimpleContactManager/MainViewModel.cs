using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

            DeleteContact = new RelayCommand(DeleteContactAction);
            AddContact = new RelayCommand(AddContactAction);
        }

        public ICommand DeleteContact { get; private set; }
        public ICommand AddContact { get; private set; }

        public void DeleteContactAction()
        {
            Contacts.Remove(SelectedContact);
        }

        private void AddContactAction()
        {
            Contact contact = new Contact { Name = "New Contact" };
            EditingContact = contact;
            Contacts.Add(contact);
        }

        public ObservableCollection<Contact> Contacts { get; set; }

        public bool IsEditing
        {
            get
            {
                return EditingContact != null;
            }
        }

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                Set(() => SelectedContact, ref selectedContact, value);
                EditingContact = null;
            }
        }

        private Contact editingContact;
        public Contact EditingContact
        {
            get
            {
                return editingContact;
            }
            set
            {
                Set(() => EditingContact, ref editingContact, value);
                RaisePropertyChanged(() => IsEditing);
            }
        }
    }
}
