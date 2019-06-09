using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.Helper
{
    public class Seat
    {
        private string _Row;
        private int _SeatNumber;
        private bool _Status;

        public Seat(string Row, int SeatNumber)
        {
            this.Row = Row;
            this.SeatNumber = SeatNumber;
            this.Status = true;
        }

        public Seat(int seatNumber)
        {
            this.SeatNumber = seatNumber;
            this.Status = true;
        }

        public string Row { get => _Row; set => _Row = value; }
        public int SeatNumber { get => _SeatNumber; set => _SeatNumber = value; }
        public bool Status { get => _Status; set => _Status = value; }

        public override string ToString()
        {
            return $"{SeatNumber}";
        }
    }
}
