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

namespace VistasCineWPF
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCrearFunciones_Click(object sender, RoutedEventArgs e)
        {
            CrearFuncion crear = new CrearFuncion();
            crear.Show();
            this.Close();
        }

        private void BtnFunExisten_Click(object sender, RoutedEventArgs e)
        {
            FuncionExistente existente = new FuncionExistente();
            existente.Show();
            this.Close();
        }

        private void BtnCorte_Click(object sender, RoutedEventArgs e)
        {
            PuntodeCorte corte = new PuntodeCorte();
            corte.Show();
            this.Close();
        }

        private void BtnRegistro_Click(object sender, RoutedEventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
            this.Close();
        }

        private void BtnAgregarPelicula_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
