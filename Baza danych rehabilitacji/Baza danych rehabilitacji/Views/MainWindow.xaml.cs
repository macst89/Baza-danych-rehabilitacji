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

namespace Baza_danych_rehabilitacji
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRejestruj_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRejestruj_Click(object sender, RoutedEventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            if (rejestracja.IsActive == false)
            { 
                
                rejestracja.Show();
            }
            else
            {
                MessageBox.Show("Okno rejestracji jest już otwarte.");
                rejestracja.Close();
            }
        }
    }
}
