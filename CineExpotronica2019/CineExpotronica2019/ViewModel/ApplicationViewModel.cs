using CineExpotronica2019.Helper;
using CineExpotronica2019.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CineExpotronica2019.ViewModel
{
    public class ApplicationViewModel:NotifyViewModel
    {
        private CrearFuncionControl CrearFuncionPage { get { return new CrearFuncionControl(); } }
        private AddMovieControl MoviePage { get { return new AddMovieControl(); } }
        public VentaBoletosControl VentaBoletosPage { get { return new VentaBoletosControl(); } }
        private object currentView;

        public ApplicationViewModel()
        {

        }
        public ICommand SetMoviePage
        {
            get { return new DelegateCommand((o) => { control = MoviePage; NotifyPropertyChanged("CurrentPage"); }); }
        }
        public ICommand SetCrearFuncionPage
        {
            get { return new DelegateCommand((o) => { control = CrearFuncionPage; NotifyPropertyChanged("CurrentPage"); }); }
        }
        public ICommand SetVentaBoletosPage
        {
            get { return new DelegateCommand((o) => { control = VentaBoletosPage; NotifyPropertyChanged("CurrentPage"); }); }
        }
        private UserControl control;
        public UserControl CurrentPage
        {
            get { return control; }
        }


        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                NotifyPropertyChanged("CurrentView");
            }
        }
    }
}
