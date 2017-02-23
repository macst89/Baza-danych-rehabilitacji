﻿using System;
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
        private Patient patient = new Patient();
        
        

        private void txtPesel_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPesel.Text != null && txtPesel.Text.Length == 11)
            {
                string pesel = txtPesel.Text;
                int plec = Convert.ToInt32(pesel.Substring(9, 1));
                string data_ur = "19" + pesel.Substring(0, 2) + "-" + pesel.Substring(2, 2) + "-" + pesel.ToString().Substring(4, 2);
                txtBirthDate.Text = data_ur;
                if (plec % 2 != 0)
                {
                    txtGender.Text = "M";
                }
                else
                {
                    txtGender.Text = "K";
                }
                
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                patient.AddAddress(txtStreet.Text, txtStreetNo.Text, txtTown.Text, txtPostalCode.Text);
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
            
        }
    }
}
