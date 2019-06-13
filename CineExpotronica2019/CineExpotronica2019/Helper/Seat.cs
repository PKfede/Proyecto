using CineExpotronica2019.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.Helper
{
    public class Seat: NotifyViewModel
    {
        private string _Row;
        private int _SeatNumber;
        private bool _Status;
        int _Position; //Esto es para la posicion del asiento pero para la bd

        public Seat(string Row, int SeatNumber)
        {
            this.Row = Row;
            this.SeatNumber = SeatNumber;
            this.Status = true;
        }
        public Seat(bool status, int position)
        {
            this.Status = status;
            this.Position = position;
        }
        public Seat(int seatNumber)
        {
            this.SeatNumber = seatNumber;
            this.Status = true;
        }

        public string Row { get => _Row; set => _Row = value; }
        public int SeatNumber { get => _SeatNumber; set => _SeatNumber = value; }
        public bool Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
            }
        }
        public int Position { get => _Position; set => _Position = value; }
       
        public override string ToString()
        {
            return $"{SeatNumber}";
        }
    }
}
