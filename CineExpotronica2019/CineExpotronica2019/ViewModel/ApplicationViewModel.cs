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
        private CrearFuncionControl CrearFuncionPage;
        private AddMovieControl MoviePage;
        public VentaBoletosControl VentaBoletosPage;
        private object currentView;

        public ApplicationViewModel()
        {
            MoviePage = new AddMovieControl();
            CrearFuncionPage = new CrearFuncionControl();
            VentaBoletosPage = new VentaBoletosControl();
            SetMoviePage = new DelegateCommand((o) => { control = MoviePage; NotifyPropertyChanged("CurrentPage");});
            SetCrearFuncionPage = new DelegateCommand((o) => { control = CrearFuncionPage; NotifyPropertyChanged("CurrentPage");});
            SetVentaBoletosPage= new DelegateCommand((o) => { control = VentaBoletosPage; NotifyPropertyChanged("CurrentPage");});
        }
        public ICommand SetMoviePage
        {
            get;
        }
        public ICommand SetCrearFuncionPage
        {
            get;
        }
        public ICommand SetVentaBoletosPage
        {
            get;
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
