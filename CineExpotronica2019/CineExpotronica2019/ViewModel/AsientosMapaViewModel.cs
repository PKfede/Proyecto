using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CineExpotronica2019.ViewModel
{
    public class AsientosMapaViewModel : BaseViewModel<ventas>
    {
        public AsientosMapaViewModel()
        {
            WorkingItem = new ventas();
            WorkingItem.cantidad_boletos = 0;
        }
        #region Properties Collection
        private enum Rows { N, M, L, K, J, I, H, G, F, E, D, C, B, A };
        private ObservableCollection<Seat> seatsTop;
        public ObservableCollection<Seat> SeatsTop
        {
            get { return seatsTop; }
            set
            {
                seatsTop = value;
                NotifyPropertyChanged("SeatsTop");
            }
        }
        private ObservableCollection<Seat> seatsMid;
        public ObservableCollection<Seat> SeatsMid
        {
            get { return seatsMid; }
            set
            {
                seatsMid = value;
                NotifyPropertyChanged("SeatsMid");
            }
        }
        private ObservableCollection<Seat> seatsBot;
        public ObservableCollection<Seat> SeatsBot
        {
            get { return seatsBot; }
            set
            {
                seatsBot = value;
                NotifyPropertyChanged("SeatsBot");
            }
        }
        public List<funcion> FuncionList { get { return db.funcion.ToList(); } }
        #endregion

        #region Properties
        public funcion CurrentFuncion
        {
            get { return WorkingItem.funcion; }
            set
            {
                if(value != null)
                {
                    WorkingItem.funcion = value;
                    GenerateDiagram();
                }
            }
        }
        public Nullable<int> Cantidad_boletos
        {
            get {return WorkingItem.cantidad_boletos; }
            set
            {
                WorkingItem.cantidad_boletos = value;
                NotifyPropertyChanged("Cantidad_boletos");
            }
        }
        #endregion

        #region Commands

        public DelegateCommand SaveChangesCommand
        {
            get { return new DelegateCommand(SaveChanges, SaveChangesCanUse); }
        }
        public DelegateCommand MoreTicketCommand
        {
            get { return new DelegateCommand(MoreTicket); }
        }
        public DelegateCommand LessTicketCommand
        {
            get { return new DelegateCommand(LessTicket); }
        }
        #endregion

        #region Execute
        public void SaveChanges(object parameter)
        {
            char[] aux = CurrentFuncion.diagrama.ToCharArray();
            foreach (Seat seat in SeatsTop)
                {
                    if (seat.Status == true)
                    {
                        if (aux[seat.Position] == '1')
                        {
                            aux[seat.Position] = '0';
                        }
                    }
                    else
                    {
                        if (aux[seat.Position] == '0')
                        {
                            aux[seat.Position] = '1';
                        }
                    }
                }
            foreach (Seat seat in SeatsMid)
                {
                    if (seat.Status == true)
                    {
                        if (aux[seat.Position] == '1')
                        {
                            aux[seat.Position] = '0';
                        }
                    }
                    else
                    {
                        if (aux[seat.Position] == '0')
                        {
                            aux[seat.Position] = '1';
                        }
                    }
                }
            foreach (Seat seat in SeatsBot)
                {
                    if (seat.Status == true)
                    {
                        if (aux[seat.Position] == '1')
                        {
                            aux[seat.Position] = '0';
                        }
                    }
                    else
                    {
                        if (aux[seat.Position] == '0')
                        {
                            aux[seat.Position] = '1';
                        }
                    }
                }
            db.funcion.Find(CurrentFuncion.fechaFuncion, CurrentFuncion.horaFuncion, CurrentFuncion.fk_idPelicula).diagrama= new string(aux);
            db.SaveChanges();
            
        }
        public void MoreTicket(object parameter)
        {
            if(Cantidad_boletos!=219)
            {
                Cantidad_boletos++;
            }
        }
        public void LessTicket(object parameter)
        {
            if(Cantidad_boletos !=0)
            {
                Cantidad_boletos--;
            }
        }
        #endregion

        #region CanExecute
        private bool SaveChangesCanUse(object parameter)
        {
            if (CurrentFuncion == null)
                return false;
            return true;
        }

        #endregion
        public void GenerateDiagram()
        {
            //0 es false 1 es true
            char[] aux = CurrentFuncion.diagrama.ToCharArray();
            int cont = 0;
            SeatsTop = new ObservableCollection<Seat>();
            for (int i = 0; i < 19; i++)
            {
                if (aux[cont] == '0')
                {
                    SeatsTop.Add(new Seat(true, cont));
                }
                else
                {
                    SeatsTop.Add(new Seat(false, cont));
                }
                cont++;
            }
            SeatsMid = new ObservableCollection<Seat>();
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 17; i++)
                {
                    if (aux[cont] == '0')
                    {
                        SeatsMid.Add(new Seat(true, cont));
                    }
                    else
                    {
                        SeatsMid.Add(new Seat(false, cont));
                    }
                    cont++;
                }
            }
            SeatsBot = new ObservableCollection<Seat>();
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (aux[cont] == '0')
                    {
                        SeatsBot.Add(new Seat(true, cont));
                    }
                    else
                    {
                        SeatsBot.Add(new Seat(false, cont));
                    }
                    cont++;
                }
            }
        }
    }
}
