﻿using CineExpotronica2019.ViewModel;
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
    /// Lógica de interacción para CrearFuncionControl.xaml
    /// </summary>
    public partial class CrearFuncionControl : UserControl
    {
        public CrearFuncionControl()
        {
            InitializeComponent();
            ViewModel = new FuncionViewModel();
        }
        public FuncionViewModel ViewModel
        {
            get { return DataContext as FuncionViewModel; }
            set
            {
                DataContext = value;
            }
        }
    }
}
