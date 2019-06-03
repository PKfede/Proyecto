using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistasCineWPF.Helpers;
using VistasCineWPF.Model;

namespace VistasCineWPF.ViewModel
{
    public class RegistroViewModel : BaseViewModel<usuario>
    {
        public DelegateCommand AddCommand { get; private set; }
        public ObservableCollection<string> ItemsComboBox { get; private set; }
        public RegistroViewModel()
        {
            ItemsComboBox = new ObservableCollection<string>()
            {
                "Administrador",
                "Empleado"
            };
            WorkingItem = new usuario();
            _dbSet = db.usuario as DbSet<usuario>;
            AddCommand = new DelegateCommand(Add, AddCanUse);
        }
        public void Add(object parameter)
        {
            db.usuario = base.Add();
            db.SaveChanges();
        }

        public bool AddCanUse(object parameter)
        {
            return true;
        }

    }
}
