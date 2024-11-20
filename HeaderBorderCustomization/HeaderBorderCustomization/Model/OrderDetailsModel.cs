using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderBorderCustomization.Model
{
    public class OrderDetailsModel
    {
        private string _orderID;
        private string _customerID;
        private string _customer;
        private string _shipCity;
        private string _shipCountry;
        private decimal _price;
        private bool _isAvailable;
        private int _quantity;

        // Properties
        public string OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public string Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public string ShipCity
        {
            get { return _shipCity; }
            set { _shipCity = value; }
        }

        public string ShipCountry
        {
            get { return _shipCountry; }
            set { _shipCountry = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // Constructor with 10 columns
        public OrderDetailsModel(
            string orderId, string customerId, string customer, string shipCountry, string shipCity,
            decimal price, bool isAvailable, int quantity)
        {
            OrderID = orderId;
            CustomerID = customerId;
            Customer = customer;
            ShipCountry = shipCountry;
            ShipCity = shipCity;
            Price = price;
            IsAvailable = isAvailable;
            Quantity = quantity;
        }
    }

}


 