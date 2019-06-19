using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using CineExpotronica2019.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CineExpotronica2019.ViewModel
{
    public class ApplicationViewModel:NotifyViewModel
    {
        public ApplicationViewModel()
        {

        }
        #region Properties
        private usuario mainUser;
        public usuario MainUser
        {
            get { return mainUser; }
            set
            {
                mainUser = value;
                NotifyPropertyChanged("MainUser");
            }
        }

        private UserControl control;
        public UserControl CurrentPage
        {
            get { return control; }
        }
        #endregion
        
        #region UserControls
        private CrearFuncionControl CrearFuncionPage { get { return new CrearFuncionControl(); } }
        private AddMovieControl MoviePage { get { return new AddMovieControl(); } }

        public VentaBoletosControl VentaBoletosPage { get { return new VentaBoletosControl() { ViewModel = new AsientosMapaViewModel(MainUser)}; } }
        public RegistrosControl RegistrosPage{ get { return new RegistrosControl(); } }
        #endregion

        #region Commands
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
        public ICommand SetRegistrosPage
        {
            get { return new DelegateCommand((o) => { control = RegistrosPage; NotifyPropertyChanged("CurrentPage"); }); }
        }
        public DelegateCommand LogOutCommand
        {
            get { return new DelegateCommand(LogOut); }
        }
        #endregion

        #region Execute
        
        private void LogOut(object parameter)
        {
            var Res = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (Res == MessageBoxResult.Yes)
            {
                LoginView window = new LoginView() { DataContext = new LoginViewModel() };
                window.Show();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = window;
            }
        
        
        }
        #endregion

    }
}
