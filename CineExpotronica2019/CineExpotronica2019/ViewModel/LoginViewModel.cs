using CineExpotronica2019.Helper;
using CineExpotronica2019.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineExpotronica2019.ViewModel
{
    class LoginViewModel : BaseViewModel<usuario>
    {
        private bool loginError;
        private IEnumerable<usuario> users;
        public bool LoginError
        {
            get { return loginError; }
            set
            {
                loginError = value;
                NotifyPropertyChanged("LoginError");
            }
        }
        public DelegateCommand GetLoginCommand { get; private set; }
        public DelegateCommand SignInCommand { get; private set; }

        public LoginViewModel()
        {
            WorkingItem = new usuario();
            _dbSet = db.usuario as DbSet<usuario>;
            SignInCommand = new DelegateCommand(SignIn);
            GetLoginCommand = new DelegateCommand(Login, LoginCanUse);
        }
        void OnLoginResponse(bool loginSucceded)
        {
            if (loginSucceded)
            {
                MainMenu window = new MainMenu() { DataContext = new ApplicationViewModel() };
                window.Show();

                App.Current.MainWindow.Close();
                App.Current.MainWindow = window;
            }
            else
            {
                LoginError = true;
            }
        }
        public void Login(object parameter)
        {
            OnLoginResponse(true);
        }
        public bool LoginCanUse(object parameter)
        {

            users = Get();
            //if (users.Contains(WorkingItem))
            //{
            //    return false;
            //}
            return true;
        }
        public void SignIn(object parameter)
        {
            SignInView window = new SignInView() { DataContext = new SignInViewModel() };
            window.Show();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = window;
        }
    }

}
