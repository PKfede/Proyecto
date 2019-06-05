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
        private AddMovieControl MoviePage { get { return new AddMovieControl(); }  }
        public VentaBoletosControl VentaBoletosPage;
        private object currentView;

        public ApplicationViewModel()
        {
           
            CrearFuncionPage = new CrearFuncionControl();
            VentaBoletosPage = new VentaBoletosControl();
            SetCrearFuncionPage = new DelegateCommand((o) => { control = CrearFuncionPage; NotifyPropertyChanged("CurrentPage");});
            SetVentaBoletosPage= new DelegateCommand((o) => { control = VentaBoletosPage; NotifyPropertyChanged("CurrentPage");});
        }
        public ICommand SetMoviePage
        {
            get { return new DelegateCommand((o) => { control = MoviePage; NotifyPropertyChanged("CurrentPage"); }); }
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
