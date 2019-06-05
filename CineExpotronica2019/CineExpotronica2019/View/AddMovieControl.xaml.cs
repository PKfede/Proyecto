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
    /// Lógica de interacción para AddMovieControl.xaml
    /// </summary>
    public partial class AddMovieControl : UserControl
    {
        public AddMovieControl()
        {
            InitializeComponent();
            ViewModel = new AddPeliculaViewModel();
        } 
        public AddPeliculaViewModel ViewModel
        {
            get { return DataContext as AddPeliculaViewModel; }
            set
            {
                DataContext = value;
            }
        }
    }
}
