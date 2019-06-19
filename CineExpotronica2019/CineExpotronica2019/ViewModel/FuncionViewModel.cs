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
    public class FuncionViewModel : BaseViewModel<funcion>, IDataErrorInfo
    {

        public DelegateCommand AddCommand { get; private set; }
        public List<pelicula> ItemsComboBox { get; private set; }
        public ObservableCollection<string> ItemsComboBox2 { get; private set; }
        public FuncionViewModel()
        {   
            ItemsComboBox = db.pelicula.ToList();
            ItemsComboBox2 = new ObservableCollection<string>()
            {
                "35",
                "40",
            };
            WorkingItem = new funcion();
            _dbSet = db.funcion as DbSet<funcion>;
            AddCommand = new DelegateCommand(Add, AddCanUse);
        }

        #region Properties
        public string FechaFuncion
        {
            get { return WorkingItem.fechaFuncion; }
            set
            {
                WorkingItem.fechaFuncion = value;
            }
        }
        public string HoraFuncion
        {
            get { return WorkingItem.horaFuncion; }
            set
            {
                WorkingItem.horaFuncion = value;
            }
        }
        private string precio;
        public string Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                NotifyPropertyChanged("Precio");
            }
        }
        public pelicula Pelicula
        {
            get { return WorkingItem.pelicula; }
            set
            {
                WorkingItem.pelicula = value;
                NotifyPropertyChanged("Pelicula");
            }
        }
        #endregion

        #region Execute
        public void Add(object parameter)
        {
            if(db.funcion.Find(FechaFuncion, HoraFuncion, Pelicula.idPelicula) == null)
            {
                WorkingItem.diagrama = "0000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "00000000000000000000000000000" +
                "000000000";
                WorkingItem.asientosDisponibles = 219;
                WorkingItem.asientosOcupados = 0;
                WorkingItem.precio = Int32.Parse(Precio);
                db.funcion = base.Add();
                db.SaveChanges();
                MessageBox.Show("Función guardada");
            }
            else
            {
                MessageBox.Show("Error: Función existente", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
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
        public readonly string[] ValidatesProperties =
        {
            "FechaFuncion",
            "HoraFuncion",
            "Pelicula"
        };
        public string GetValidationError(string propertyName)
        {
            string errorMsg = null;

            if (propertyName.Equals("FechaFuncion"))
            {
                if (String.IsNullOrEmpty(FechaFuncion))
                {
                    errorMsg = "Es un campo obligatorio";
                }
                
            }
            else if (propertyName.Equals("HoraFuncion"))
            {
                if (String.IsNullOrEmpty(HoraFuncion))
                    errorMsg = "Es un campo obligatorio";
            }
            else if(propertyName.Equals("Pelicula"))
            {
                if (Pelicula == null)
                    errorMsg = "Es un campo obligatorio";
            }
            return errorMsg;
        }
        #endregion



    }
}
