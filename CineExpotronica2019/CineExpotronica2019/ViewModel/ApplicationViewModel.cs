using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.ViewModel
{
    class ApplicationViewModel:NotifyViewModel
    {
        public SignInViewModel SignInVM;
        public LoginViewModel LoginVM;

        //private SignInView signInV;
        //private LoginView loginV;
        private object currentView;
        private int currentHeight = 350;
        private int currentWidth = 650;
       

        public ApplicationViewModel()
        {
            SignInVM = new SignInViewModel();
            LoginVM = new LoginViewModel(); 
        }
        public int CurrentHeight
        {
            get { return currentHeight; }
            private set
            {
                currentHeight = value;
                NotifyPropertyChanged("CurrentHeight");
            }
        }
        public static void setLoginView()
        {
            
        }
        public int CurrentWidth
        {
            get { return currentWidth; }
            private set
            {
                currentWidth = value;
                NotifyPropertyChanged("CurrentWidth");
            }
        }

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                NotifyPropertyChanged("CurrentView");
            }
        }
    }
}
