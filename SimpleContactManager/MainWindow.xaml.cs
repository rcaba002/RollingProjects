using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleContactManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;

        public MainWindow()
        {
            InitializeComponent();

            contacts = new List<Contact> {
                new Contact("John Doe", "jdoe@example.com", "314-555-1234", "123 Main"),
                new Contact("Jane Doe", "jadoe@example.com", "314-555-3122", "345 Main"),
                new Contact("Andrew Benz", "andorbal@gmail.com", "", ""),
                new Contact("Superman", "superman@example.com", "314-555-1235", "Fortress of Solitude")
            };

            foreach (var contact in contacts) 
            {
                ContactList.Items.Add(contact);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We should load data here...");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We should save data here...");
        }
    }
}
