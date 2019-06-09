using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CineExpotronica2019.ViewModel
{
    public class AsientosMapaViewModel : BaseViewModel<ventas>
    {
        private enum Rows { N, M, L, K, J, I, H, G, F, E, D, C, B, A };
        public ObservableCollection<Seat> SeatsTop { get; private set; }
        public ObservableCollection<Seat> SeatsMid { get; private set; }
        public ObservableCollection<Seat> SeatsBot { get; private set; }

        public List<funcion> FuncionList { get; private set; }
        public DelegateCommand SelectCommand;
        public AsientosMapaViewModel()
        {
            FuncionList = db.funcion.ToList();
            GenerateDiagram();
            SelectCommand = new DelegateCommand(Select);

        }

        #region Execute y canExecute
        public void Select(object parameter)
        {
            MessageBox.Show("seleccionado");
        }


        #endregion

        public void GenerateDiagram()
        {
            SeatsTop = new ObservableCollection<Seat>();
            for (int i = 1; i <= 19; i++)
            {
                SeatsTop.Add(new Seat("N", i));
            }
            SeatsMid = new ObservableCollection<Seat>();
            for (int j = 1; j <= 6; j++)
            {
                if (j <= 7)
                {
                    for (int i = 1; i <= 17; i++)
                    {
                        SeatsMid.Add(new Seat(i));
                    }
                }
            }
            SeatsBot = new ObservableCollection<Seat>();
            for (int j = 1; j <= 7; j++)
            {
                if (j <= 7)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        SeatsBot.Add(new Seat(i));
                    }
                }
            }
        }
    }
}
