using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.Models;
using System.Windows;
using System.Windows.Input;
using WPFMVVM.Commands;

namespace WPFMVVM.ViewModels
{
    class CustomerViewModel
    {
        private List<Customer> _Customer = new List<Customer>();
        private int index = 0;

        public CustomerViewModel()
        {
            _Customer.Add(new Customer("Martin1"));
            _Customer.Add(new Customer("Martin2"));
            _Customer.Add(new Customer("Martin3"));
            _Customer.Add(new Customer("Martin4"));

            UpdateCommand = new CustomerUpdateCommand(this);
            NextCommand = new CustomerNextCommand(this);
        }

        public Customer Customer
        {
            get
            {
                return _Customer[index];
            }
        }

        public bool CanUpdate
        {
            get
            {
                if (_Customer[index] == null)
                    return false;

                return !String.IsNullOrEmpty(Customer.Name);
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public ICommand NextCommand
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            MessageBox.Show("Saved: " + _Customer[index].Name + " !");
        }

        public void NextCustomer()
        {
            index++;
            if (index == _Customer.Count)
            {
                index = 0;
            }

            for(int i = 0; i < _Customer.Count; i++)
                _Customer[i].Refresh();
        }
    }
}
