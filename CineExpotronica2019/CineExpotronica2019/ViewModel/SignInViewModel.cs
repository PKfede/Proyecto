using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CineExpotronica2019.ViewModel
{
    public class SignInViewModel : BaseViewModel<usuario>, IDataErrorInfo
    {
        public ObservableCollection<string> ItemsComboBox { get; private set; }
        #region Properties
        public string Nombre_usuario
        {
            get { return WorkingItem.nombre_usuario; }
            set
            {
                WorkingItem.nombre_usuario = value;
            }
        }
        public string TelTaquillero
        {
            get { return WorkingItem.telTaquillero; }
            set
            {
                WorkingItem.telTaquillero = value;
            }
        }
        public string Nombre
        {
            get { return WorkingItem.nombre; }
            set
            {
                WorkingItem.nombre= value;
            }
        }
        public string ApPaterno
        {
            get { return WorkingItem.apPaterno; }
            set
            {
                WorkingItem.apPaterno = value;
            }
        }
         public string ApMaterno
        {
            get { return WorkingItem.apMaterno; }
            set
            {
                WorkingItem.apMaterno = value;
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

        

        #endregion
        public SignInViewModel()
        {
            ItemsComboBox = new ObservableCollection<string>()
            {
                "Empleado",
                "Administrador"
            };
            WorkingItem = new usuario();
            _dbSet = db.usuario as DbSet<usuario>;
            AddCommand = new DelegateCommand(Add, AddCanUse);
            BackToLoginCommand = new DelegateCommand(BackToLogin);
        }

        #region Commands
        public DelegateCommand BackToLoginCommand { get; private set; }
        public DelegateCommand AddCommand { get; private set; }
        #endregion

        #region Execute
        public void Add(object parameter)
        {
            db.usuario = base.Add();
            db.SaveChanges();
        }
        public void BackToLogin(object parameter)
        {
            LoginView window = new LoginView() { DataContext = new LoginViewModel() };
            window.Show();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
        }
        #endregion

        #region canExecute
        public bool AddCanUse(object parameter)
        {
            foreach (string property in ValidatesProperties)
            {
                if (GetValidationError(property) != null)
                { return false; }
            }
            return true;
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
                return GetValidationError(propertyName);
            }
        }
        #endregion

        #region Validation
        static readonly string[] ValidatesProperties =
        {
            "Nombre",
            "Nombre_usuario",
            "TelTaquillero",
            "ApPaterno",
            "ApMaterno",
            "Contra"
        };
        public string GetValidationError(string propertyName)
        {
            string errorMsg = null;
            

            if (propertyName.Equals("Nombre_usuario"))
            {
                if (String.IsNullOrEmpty(Nombre_usuario))
                    errorMsg = "Es un campo obligatorio";
                else if (Nombre_usuario.Length < 6)
                    errorMsg = "Nombre de usuario debe tener al menos seis caracteres";
                else if(Nombre_usuario.Length>50)
                {
                    errorMsg = "El nombre es muy largo";
                }
                else if (_dbSet.Where(value => value.nombre_usuario == WorkingItem.nombre_usuario).Count() > 0)
                {
                    errorMsg = "Nombre de usuario ya existente";
                }
            }
            else if (propertyName.Equals("TelTaquillero"))
            {
                if (!TelTaquillero.All(char.IsDigit))
                {
                    errorMsg = "Teléfono solo debe contener números";
                }
                else if(TelTaquillero.Length != 10)
                {
                    errorMsg = "Ingrese un numero valido";
                }
            }
            else if (propertyName.Equals("Nombre"))
            {
                if (String.IsNullOrEmpty(Nombre))
                    errorMsg = "Es un campo obligatorio";
                else if(Nombre.Length > 50)
                {
                    errorMsg = "El nombre es muy largo";
                }
            }
            else if(propertyName.Equals("ApPaterno"))
            {
                if (String.IsNullOrEmpty(ApPaterno))
                    errorMsg = "Es un campo obligatorio";
                else if (ApPaterno.Length > 50)
                {
                    errorMsg = "El nombre es muy largo";
                }
            }
            else if(propertyName.Equals("ApMaterno"))
            {
                if (ApMaterno.Length > 50)
                {
                    errorMsg = "El nombre es muy largo";
                }
            }
            else if(propertyName.Equals("Contra"))
            {
                if (String.IsNullOrEmpty(Contra))
                    errorMsg = "Es un campo obligatorio";
                else if (Contra.Length < 4)
                    errorMsg = "La contraseña debe tener al menos cuatro caracteres";
                if (Contra.Length > 50)
                {
                    errorMsg = "El nombre es muy largo";
                }
            }

            return errorMsg;
        }
        #endregion
       
    }
}
