namespace MVVM_example.ViewModel
{
    using System;
    using System.Diagnostics;
    using MVVM_example.Model;

    internal class CustomerViewModel
    {
        /// <summary>
        /// Initializes a new instance of CustomerViewModel class
        /// </summary>
        public CustomerViewModel() {
            _Customer = new Customer("Ratafak");
        }

        private Customer _Customer;
        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
        }

          /// <summary>
          /// Save changes made to the Customer instance.
          /// </summary>
          public void SaveChanges() {
            Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
          }

    }
}
