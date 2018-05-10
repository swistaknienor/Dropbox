namespace MVVM_example.Model
{
    using System;
    using System.ComponentModel;

    public class Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// initializes a new instance of Customer class
        /// </summary>
        /// <param name="customerName"></param>
        public Customer(String customerName) {
            Name = customerName;
        }

        private string _Name;
        /// <summary>
        /// Gets or sets the name of Customer
        /// </summary>
        public String Name {
            get {
                return _Name;
            }
            set {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}