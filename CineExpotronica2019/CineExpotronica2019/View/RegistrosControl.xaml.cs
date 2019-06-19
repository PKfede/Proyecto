using CineExpotronica2019.ViewModel;
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

namespace CineExpotronica2019.View
{
    /// <summary>
    /// Lógica de interacción para RegistrosControl.xaml
    /// </summary>
    public partial class RegistrosControl : UserControl
    {
        public RegistrosControl()
        {
            InitializeComponent();
            ViewModel = new RegistrosViewModel();

        }
        public RegistrosViewModel ViewModel
        {
            get { return DataContext as RegistrosViewModel; }
            set
            {
                DataContext = value;
            }
        }
    }
}
