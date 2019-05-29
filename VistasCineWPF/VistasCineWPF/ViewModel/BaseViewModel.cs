using VistasCineWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasCineWPF.ViewModel
{
    public class BaseViewModel<T> : NotifyViewModel where T : class
    {
        protected cineEntities db = new cineEntities();
        protected DbSet<T> _dbSet;
        protected T _WorkingItem;

        
        public T WorkingItem { get { return _WorkingItem; } set { _WorkingItem = value; NotifyPropertyChanged("WorkingItem"); } }
        public DbSet<T> Add()
        {
            _dbSet.Add(WorkingItem);
            return _dbSet;
        }
        public virtual void Delete() { }

        public T FindById(string nombre)
        {
            return _dbSet.Find(nombre);
        }
        public virtual void Edit() { }
    }
}
