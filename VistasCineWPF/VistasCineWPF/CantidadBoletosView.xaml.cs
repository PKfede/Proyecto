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

namespace VistasCineWPF
{
    /// <summary>
    /// Lógica de interacción para CantidadBoletosView.xaml
    /// </summary>
    public partial class CantidadBoletosView : Window
    {
        public CantidadBoletosView()
        {
            InitializeComponent();
        }

        private void BtnCantBoletos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRegresarCant_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

   
    }
}
