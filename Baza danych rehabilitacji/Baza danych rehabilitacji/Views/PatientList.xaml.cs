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


namespace Baza_danych_rehabilitacji.Views
{
    /// <summary>
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        public PatientList()
        {
            InitializeComponent();
            this.DataContext = patients;
            lbPatients.ItemsSource = patients;
            
        }
        Patient patient = new Patient();
        List<Patient> patients = new List<Patient>();

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
    }
}
