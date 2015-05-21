using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        public MainViewModel ViewModel
        {
            get
            {
                return DataContext as MainViewModel;
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
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON Document (*.json)|*.json";

            if (dialog.ShowDialog().GetValueOrDefault())
            {
                string data = JsonConvert.SerializeObject(ViewModel.Contacts, Formatting.Indented);
                using (Stream steam = dialog.OpenFile())
                {
                    using (StreamWriter writer = new StreamWriter(steam))
                    {
                        writer.Write(data);
                    }
                }
            }
        }
    }
}
