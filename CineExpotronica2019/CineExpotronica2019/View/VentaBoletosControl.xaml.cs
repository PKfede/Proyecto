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
    /// Lógica de interacción para VentaBoletosControl.xaml
    /// </summary>
    public partial class VentaBoletosControl : UserControl
    {
        public VentaBoletosControl()
        {
            InitializeComponent();
            ViewModel = new AsientosMapaViewModel();
        }
        public AsientosMapaViewModel ViewModel
        {
            set { this.DataContext = value; }
            get { return this.DataContext as AsientosMapaViewModel; }
        }
        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            Rectangle r = sender as Rectangle;
            r.Fill = new SolidColorBrush(System.Windows.Media.Colors.Blue); ;
            MessageBox.Show("seleccionado");
        }
    }
}
