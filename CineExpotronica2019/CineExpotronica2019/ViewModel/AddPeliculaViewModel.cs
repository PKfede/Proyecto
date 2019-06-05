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
    public class AddPeliculaViewModel : BaseViewModel<pelicula>, IDataErrorInfo
    {
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand DeleteCommand { get; private set; }
        private List<pelicula> peliculas;
        public List<pelicula> PeliculasList
        {
            get { return peliculas; }
            set
            {
                peliculas = value;
                NotifyPropertyChanged("PeliculasList");
            }
        }
        #region Properties
        public string Nombre
        {
            get { return WorkingItem.nombre; }
            set
            {
                WorkingItem.nombre = value;
            }
        }
        private pelicula selectedMovie;
        public pelicula SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                NotifyPropertyChanged("SelectedMovie");
            }
        }
        #endregion

        public AddPeliculaViewModel()
        {
            WorkingItem = new pelicula();
            _dbSet = db.pelicula as DbSet<pelicula>;
            AddCommand = new DelegateCommand(Add, AddCanUse);
            DeleteCommand = new DelegateCommand(Delete);
            PeliculasList = _dbSet.ToList();
        }

        #region Execute
        public void Add(object parameter)
        {
            db.pelicula = base.Add();
            db.SaveChanges();
            PeliculasList = _dbSet.ToList();
        }
        public void Delete(object parameter)
        {
            var Res = MessageBox.Show("Are you sure you want to delete this movie ?", "Deleting Records", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if(Res == MessageBoxResult.Yes)
            {
                db.pelicula = base.Remove(SelectedMovie);
                db.SaveChanges();
                PeliculasList = _dbSet.ToList();

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

        #region Validations
        static readonly string[] ValidatesProperties = { "Nombre" };
        string GetValidationError(string propertyName)
        {
            string errorMsg = null;

            if (propertyName.Equals("Nombre"))
            {
                if (String.IsNullOrEmpty(Nombre))
                    errorMsg = "Es un campo obligatorio";
                else if (Nombre.Length > 50)
                    errorMsg = "Nombre muy largo";
                else if (_dbSet.Where(value => value.nombre == WorkingItem.nombre).Count() > 0)
                {
                    errorMsg = "El nombre de la pelicula ya existe";
                }
            }

            return errorMsg;
        }
        #endregion
    }
}
