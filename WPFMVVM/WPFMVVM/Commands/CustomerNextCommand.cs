using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using WPFMVVM.ViewModels;

namespace WPFMVVM.Commands
{
    class CustomerNextCommand : ICommand
    {
        private CustomerViewModel _ViewModel = null;

        public CustomerNextCommand(CustomerViewModel pViewModel)
        {
            _ViewModel = pViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _ViewModel.NextCustomer();
        }
    }
}
