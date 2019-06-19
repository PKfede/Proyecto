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
        public AsientosMapaViewModel(object user)
        {
            WorkingItem = new ventas();
            WorkingItem.cantidad_boletos = 0;
            MainUser = user as usuario;
        }
        #region Properties Collection
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
                    WorkingItem.tarifa = value.precio;
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

        private usuario mainUser;
        public usuario MainUser
        {
            get { return mainUser; }
            set
            {
                mainUser = value;
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
            List<Seat> list = new List<Seat>();
            int cont = 0;
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
                        list.Add(seat);
                        cont++;
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
                        list.Add(seat);
                        cont++;
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
                        list.Add(seat);
                        cont++;
                    }
                }
            }

            if(cont == Cantidad_boletos)
            {
                var Res = MessageBox.Show("¿Estás seguro que quieres confirmar la venta?", "Venta de boletos", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                if (Res == MessageBoxResult.Yes)
                {
                    db.funcion.Find(CurrentFuncion.fechaFuncion, CurrentFuncion.horaFuncion, CurrentFuncion.fk_idPelicula).diagrama= new string(aux);
                    db.funcion.Find(CurrentFuncion.fechaFuncion, CurrentFuncion.horaFuncion, CurrentFuncion.fk_idPelicula).asientosDisponibles -= Cantidad_boletos;
                    db.funcion.Find(CurrentFuncion.fechaFuncion, CurrentFuncion.horaFuncion, CurrentFuncion.fk_idPelicula).asientosOcupados += Cantidad_boletos;
                    WorkingItem.importe = Cantidad_boletos * CurrentFuncion.precio;
                    WorkingItem.idTaquillero= MainUser.idTaquillero;
                    db.ventas.Add(WorkingItem);
                    db.SaveChanges();
                    foreach(Seat seat in list)
                    {
                        boletoVendido boleto = new boletoVendido();
                        boleto.fila_asiento = seat.Row;
                        boleto.num_asiento = seat.SeatNumber;
                        boleto.ventas = WorkingItem;
                        db.boletoVendido.Add(boleto);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Venta exitosa");
                    Cantidad_boletos = 0;
                }
            }
            else
            {
                MessageBox.Show("Error en la cantidad de boletos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

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
            if (Cantidad_boletos < 1)
                return false;

            return true;
        }

        #endregion
        public void GenerateDiagram()
        {
            //0 es false 1 es true
            string[] mid = { "M", "L", "K", "J", "I", "H" };
            string[] bot = { "G", "F", "E", "D", "C", "B", "A" };
            char[] aux = CurrentFuncion.diagrama.ToCharArray();
            int cont = 0;
            SeatsTop = new ObservableCollection<Seat>();
            for (int i = 0; i < 19; i++)
            {
                if (aux[cont] == '0')
                {
                    SeatsTop.Add(new Seat("N", i+1, true, cont));
                }
                else
                {
                    SeatsTop.Add(new Seat("N", i + 1, false, cont) { IsEnabled = false });
                }
                cont++;
            }
            SeatsMid = new ObservableCollection<Seat>();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (aux[cont] == '0')
                    {
                        
                        SeatsMid.Add(new Seat(mid[i],j+1,true, cont));
                    }
                    else
                    {
                        SeatsMid.Add(new Seat(mid[i], j + 1, false, cont) { IsEnabled = false});
                    }
                    cont++;
                }
            }
            SeatsBot = new ObservableCollection<Seat>();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (aux[cont] == '0')
                    {
                        SeatsBot.Add(new Seat(bot[i], j + 1, true, cont));
                    }
                    else
                    {
                        SeatsBot.Add(new Seat(bot[i], j + 1, false, cont) { IsEnabled = false });
                    }
                    cont++;
                }
            }
        }
    }
}
