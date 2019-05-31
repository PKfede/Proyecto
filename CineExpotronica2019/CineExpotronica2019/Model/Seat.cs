using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CineExpotronica2019.Model
{
    class Seat
    {
        private Button _Btn;
        private string _Row;
        private int _SeatNumber;
        private bool _Status;

        public Seat(Button Btn, string Row, int SeatNumber)
        {
            this.Btn = Btn;
            this.Row = Row;
            this.SeatNumber = SeatNumber;
            this.Status = true;
        }

        public Button Btn { get => _Btn; set => _Btn = value; }
        public string Row { get => _Row; set => _Row = value; }
        public int SeatNumber { get => _SeatNumber; set => _SeatNumber = value; }
        public bool Status { get => _Status; set => _Status = value; }
    }
}
