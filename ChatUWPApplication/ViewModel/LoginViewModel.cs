using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUWPApplication.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public RelayCommand<string> LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<string>(LoginCommand_Execute, (n) => { return !string.IsNullOrWhiteSpace(n); });
        }

        private void LoginCommand_Execute(string name)
        {
            throw new NotImplementedException();
        }
    }
}
