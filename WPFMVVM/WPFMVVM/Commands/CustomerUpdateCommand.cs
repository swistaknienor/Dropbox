using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVM.ViewModels;

namespace WPFMVVM.Commands
{
    class CustomerUpdateCommand : ICommand
    {
        private CustomerViewModel _ViewModel = null;

        public CustomerUpdateCommand(CustomerViewModel pViewModel)
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
            return _ViewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
