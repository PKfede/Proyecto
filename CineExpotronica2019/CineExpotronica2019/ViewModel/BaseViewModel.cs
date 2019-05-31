using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.ViewModel
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
        public virtual IEnumerable<T> Get()
        {
            return _dbSet.ToList();
        }
        public virtual IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
    }
}
