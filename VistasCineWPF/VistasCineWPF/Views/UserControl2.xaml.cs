using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VistasCineWPF.Views
{
    /// <summary>
    /// Lógica de interacción para UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public ObservableCollection<int> SeatsTop { get; private set; }
        public ObservableCollection<int> SeatsMid { get; private set; }
        public ObservableCollection<int> SeatsBot { get; private set; }

        public UserControl2()
        {
            SeatsTop = new ObservableCollection<int>();
            for (int i = 1; i <= 19; i++)
            {
           
                    SeatsTop.Add(i);
            }
            SeatsMid = new ObservableCollection<int>();

            //for (int i = 1; i <= 102; i++)
            //{
                
            //    SeatsMid.Add(i+19);

            //}

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
            //for (int i = 1; i <= 98; i++)
            //{

            //    SeatsBot.Add(i+121);
            //}

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

            InitializeComponent();
        }
    }
}
