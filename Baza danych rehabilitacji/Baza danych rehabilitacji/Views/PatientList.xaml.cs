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

            ICollectionView view = CollectionViewSource.GetDefaultView(lbPatients.DataContext);
            view.Refresh();

        }
        


    }
}
