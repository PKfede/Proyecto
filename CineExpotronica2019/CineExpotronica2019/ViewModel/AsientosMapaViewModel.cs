﻿using CineExpotronica2019.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CineExpotronica2019.ViewModel
{
    public class AsientosMapaViewModel : NotifyViewModel
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
    }
}
