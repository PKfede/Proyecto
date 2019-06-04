using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CineExpotronica2019.ViewModel
{
    public class LoginViewModel : BaseViewModel<usuario>, IDataErrorInfo
    {
        private bool loginError;
        private IEnumerable<usuario> users;
        #region Properties
        public string Nombre_usuario
        {
            get { return WorkingItem.nombre_usuario; }
            set
            {
                WorkingItem.nombre_usuario = value;
            }
        }
        public string Contra
        {
            get { return WorkingItem.contra; }
            set
            {
                WorkingItem.contra = value;
            }
        }
        public bool LoginError
        {
            get { return loginError; }
            set
            {
                loginError = value;
                NotifyPropertyChanged("LoginError");
            }
        }

        #endregion 
        public LoginViewModel()
        {
            WorkingItem = new usuario();
            _dbSet = db.usuario as DbSet<usuario>;
            SignInCommand = new DelegateCommand(SignIn);
            GetLoginCommand = new DelegateCommand(Login);
        }
        #region Commands
        public DelegateCommand GetLoginCommand { get; private set; }
        public DelegateCommand SignInCommand { get; private set; }
        #endregion 
        #region Execute
        void OnLoginResponse(bool loginSucceded)
        {
            if (loginSucceded)
            {
                MainMenu window = new MainMenu() { DataContext = new ApplicationViewModel() };
                window.Show();

                App.Current.MainWindow.Close();
                App.Current.MainWindow = window;
            }
            else
            {
                LoginError = true;
            }
        }
        public void Login(object parameter)
        {
            if (_dbSet.Where(value => value.nombre_usuario == Nombre_usuario).Where(value => value.contra == Contra).Count() > 0)
            {
                OnLoginResponse(true);
            }
            else
            {
                MessageBox.Show("Inicio de sesion fallido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void SignIn(object parameter)
        {
            SignInView window = new SignInView() { DataContext = new SignInViewModel() };
            window.Show();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
        }
        #endregion
        #region CanExecute
        public bool LoginCanUse(object parameter)
        {   
            return true;
        }
        #endregion

        #region Validation
        static readonly string[] ValidatesProperties =
        {
            "Nombre_usuario",
            "Contra"
        };
        public string GetValidationError(string propertyName)
        {
            string errorMsg = String.Empty;


            if (propertyName.Equals("Nombre_usuario"))
            {
                if (String.IsNullOrEmpty(Nombre_usuario))
                    errorMsg = "Es un campo obligatorio";
                else if (Nombre_usuario.Length < 6)
                    errorMsg = "Nombre de usuario debe tener al menos seis caracteres";
                else if (Nombre_usuario.Length > 50)
                {
                    errorMsg = "El nombre es muy largo";
                }
                else if (_dbSet.Where(value => value.nombre_usuario == WorkingItem.nombre_usuario).Count() > 0)
                {
                    errorMsg = "Nombre de usuario ya existente";
                }
            }


            return errorMsg;
        }
        #endregion
        #region IDataErrorInfo
        public string Error
        {
            get { return null; }
        }
        public string this[string propertyName]
        {
            get
            {
                return null;//GetValidationError(propertyName);
            }
        }
        #endregion


    }

}
