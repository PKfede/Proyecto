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

namespace CineExpotronica2019.ViewModel
{
    public class FuncionViewModel : BaseViewModel<funcion>, IDataErrorInfo
    {

        public DelegateCommand AddCommand { get; private set; }
        public ObservableCollection<string> ItemsComboBox { get; private set; }
        public ObservableCollection<decimal> ItemsComboBox2 { get; private set; }

        public FuncionViewModel()
        {
            ItemsComboBox = new ObservableCollection<string>()
            {
                "Godzilla",
                "John Wick 3"
            };
            ItemsComboBox2 = new ObservableCollection<decimal>()
            {
                35,
                40
            };
            WorkingItem = new funcion();
            _dbSet = db.funcion as DbSet<funcion>;
            AddCommand = new DelegateCommand(Add, AddCanUse);
        }

        #region Properties
        public string IdFuncion
        {
            get { return WorkingItem.idFuncion; }
            set
            {
                WorkingItem.idFuncion = value;
            }
        }
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
        public pelicula x
        {
            get { return WorkingItem.pelicula; }
            set
            {
                WorkingItem.pelicula = value;
            }
        }

        #endregion

        #region Execute
        public void Add(object parameter)
        {
            db.funcion = base.Add();
            db.SaveChanges();
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
            "IdFuncion",
            "FechaFuncion",
            "HoraFuncion"
        };
        string GetValidationError(string propertyName)
        {
            string errorMsg = null;


            if (propertyName.Equals("IdFuncion"))
            {
                if (String.IsNullOrEmpty(IdFuncion))
                    errorMsg = "Es un campo obligatorio";
                
            }
            else if (propertyName.Equals("FechaFuncion"))
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

            return errorMsg;
        }
        #endregion



    }
}
