using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.Model
{
    class SeatingDiagram
    {
        private Seat[,] SeatDiagram = new Seat[14, 17];
        private enum Rows { N, M, L, K, J, I, H, G, F, E, D, C, B, A };


        public SeatingDiagram()
        {

        }

        private void AssignRows()
        {
            for (int i = 0; i < 14; ++i)
            {
                for (int j = 0; j < 17; ++j)
                {

                }
            }
        }
    }
}
