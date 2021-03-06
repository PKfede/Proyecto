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
using System.Windows.Shapes;

namespace CineExpotronica2019
{
    /// <summary>
    /// Lógica de interacción para LoginV.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
        }
        
        public LoginViewModel ViewModel
        {
            set { this.DataContext = value; }
            get { return this.DataContext as LoginViewModel; }
        }
    }
}
