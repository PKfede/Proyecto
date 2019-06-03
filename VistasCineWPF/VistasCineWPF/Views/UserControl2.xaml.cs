using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using VistasCineWPF.Helpers;
using VistasCineWPF.ViewModel;


namespace VistasCineWPF.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
 
        

        public UserControl2()
        {
            InitializeComponent();
            this.DataContext = new AsientosMapaViewModel();
        }



        private void EventTrigger_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("seleccionado");
        }

        private void EventTrigger_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
