using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.ViewModel
{
    public class RegistrosViewModel: BaseViewModel<ventas>
    {
        public RegistrosViewModel()
        {
            BuscarPorComboBox = new ObservableCollection<string>(){ "Fecha", "Pelicula" };
            SelectedIndex = 0;
        }

        #region Properties Collection
        public ObservableCollection<string> BuscarPorComboBox { get; private set; }
        private List<ventas> listBoletos;
        public List<ventas> ListBoletos
        {
            get { return listBoletos; }
            set
            {
                listBoletos = value;
                NotifyPropertyChanged("ListBoletos");
            }
        }
        #endregion 

        #region Properties
        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                NotifyPropertyChanged("SelectedIndex");
            }
        }
        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set
            {
                buscar = value;
                NotifyPropertyChanged("Buscar");
            }
        }
        #endregion

        #region Commands
        public DelegateCommand FindCommand
        {
            get { return new DelegateCommand(Find); }
        }
        #endregion

        #region Execute
        public void Find(object parameter)
        {
            if(SelectedIndex == 0)
            {
                ListBoletos = db.ventas.SqlQuery($"Select * from ventas where fechaFuncion LIKE '{Buscar}%' ").ToList();
            }
            else
            {
                string q = $"select * from ventas v join funcion f on v.fechaFuncion = f.fechaFuncion and v.horaFuncion = f.horaFuncion where f.fk_idPelicula in (select idPelicula from pelicula p join funcion f on p.idPelicula = f.fk_idPelicula where p.nombre LIKE '{Buscar}%')";
                ListBoletos = db.ventas.SqlQuery(q).ToList();
            }
        }
        #endregion

    }
}
