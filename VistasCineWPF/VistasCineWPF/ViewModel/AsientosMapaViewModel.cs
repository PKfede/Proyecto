using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistasCineWPF.Views;

namespace VistasCineWPF.ViewModel
{
    class AsientosMapaViewModel:NotifyViewModel
    {
        private object view;
        public AsientosMapaViewModel()
        {
            View = new UserControl2();
        }

        public object View
        {
            get { return view; }
            set
            {
                view = value;
                NotifyPropertyChanged("View");
            }
        }
    }
}
