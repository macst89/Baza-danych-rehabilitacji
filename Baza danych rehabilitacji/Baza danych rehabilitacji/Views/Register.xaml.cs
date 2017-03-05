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
using System.Windows.Shapes;
using Baza_danych_rehabilitacji.Models;
using System.ComponentModel;

namespace Baza_danych_rehabilitacji
{
    /// <summary>
    /// Interaction logic for Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        public Rejestracja()
        {
            InitializeComponent();
            lbAddresses.ItemsSource = patient.PersonAddress;
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(lbAddresses.ItemsSource);
            try
            {             
                patient.AddAddress(txtStreet.Text, txtStreetNo.Text, txtTown.Text, txtPostalCode.Text);
                view.Refresh();
                
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Brakuje danych w adresie. Uzupełnij adres.");
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            patient.PersonAddress.Remove(lbAddresses.SelectedItem as Address);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            patients.Add(patient);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
