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

namespace VistasCineWPF
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public ObservableCollection<int> Seats { get; private set; }

        public UserControl1()
        {
            Seats = new ObservableCollection<int>();
            for (int i = 1; i <= 200; i++)
                Seats.Add(i);

            InitializeComponent();
        }
    }
}
