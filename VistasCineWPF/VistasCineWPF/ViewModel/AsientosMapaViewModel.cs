using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using VistasCineWPF.Helpers;
using VistasCineWPF.Views;
using Brush = System.Drawing.Brush;

namespace VistasCineWPF.ViewModel
{
    class AsientosMapaViewModel : NotifyViewModel
    {
        private enum Rows { N, M, L, K, J, I, H, G, F, E, D, C, B, A };
        public ObservableCollection<Seat> SeatsTop { get; private set; }
        public ObservableCollection<int> SeatsMid { get; private set; }
        public ObservableCollection<int> SeatsBot { get; private set; }
        public DelegateCommand SelectCommand;
        public AsientosMapaViewModel()
        {
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
            SeatsMid = new ObservableCollection<int>();
            for (int j = 1; j <= 6; j++)
            {
                if (j <= 7)
                {
                    for (int i = 1; i <= 17; i++)
                    {
                        SeatsMid.Add(i);
                    }
                }
            }
            SeatsBot = new ObservableCollection<int>();
            for (int j = 1; j <= 7; j++)
            {
                if (j <= 7)
                {
                    for (int i = 1; i <= 14; i++)
                    {
                        SeatsBot.Add(i);
                    }
                }
            }
        }

        //public Brush FillColor
        //{
        //    get { return this.fillColor; }
        //    set
        //    {
        //        this.fillColor = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //        }
        //    }
        //}
        private Brush _colorr = System.Drawing.Brushes.White;
        public Brush Colorr
        {
            get
            {
                return _colorr;
            }
            set
            {
                _colorr = value;
                NotifyPropertyChanged("Colorr");
            }
        }
    }
}
