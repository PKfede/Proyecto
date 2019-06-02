using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using VistasCineWPF.Views;
using Brush = System.Drawing.Brush;

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

        //public Brush FillColor
        //{
        //    get { return this.fillColor; }
        //    set
        //    {
        //        this.fillColor = value;
        //        if (PropertyChanged != null)
        //        {
        //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //        }
        //    }
        //}
        private Brush _colorr = System.Drawing.Brushes.White;
        public Brush Colorr
        {
            get
            {
                return _colorr;
            }
            set
            {
                _colorr = value;
                NotifyPropertyChanged(() => Colorr);
            }
        }

        private void NotifyPropertyChanged(Func<Brush> p)
        {
            throw new NotImplementedException();
        }
    }
}
