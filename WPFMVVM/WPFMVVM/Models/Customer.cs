using System;
using System.ComponentModel;

namespace WPFMVVM.Models
{
    class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Name = "";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public Customer(string pName)
        {
            Name = pName;
        }

        public void Refresh()
        {
            OnPropertyChanged("Name");
        }

        private void OnPropertyChanged(string pParam)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(pParam));
            }
        }
    }
}
