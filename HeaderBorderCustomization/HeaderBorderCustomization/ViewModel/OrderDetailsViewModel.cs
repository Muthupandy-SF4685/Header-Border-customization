
using HeaderBorderCustomization.Model;
using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HeaderBorderCustomization.ViewModel
{
    public class OrderDetailsViewModel
    {
        private ObservableCollection<OrderDetailsModel> orderInfo;

        public ObservableCollection<OrderDetailsModel> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public Command LongPressCommand { get; set; }

        public OrderDetailsViewModel()
        {
            orderInfo = new ObservableCollection<OrderDetailsModel>();
            this.GenerateOrders();


        }
        public void GenerateOrders()
        {
            // Creating sample data for the simplified OrderDetailsModel with 10 properties.
            orderInfo.Add(new OrderDetailsModel("1001", "ALFKI", "Maria Anders", "Berlin", "Germany", 299.99m, true, 1));
            orderInfo.Add(new OrderDetailsModel("1002", "ANATR", "Ana Trujillo", "Mexico D.F.", "Mexico", 699.99m, true, 2));
            orderInfo.Add(new OrderDetailsModel("1003", "ANTON", "Ant Fuller", "Mexico D.F.", "Mexico", 249.99m, true, 3));
            orderInfo.Add(new OrderDetailsModel("1004", "AROUT", "Thomas Hardy", "London", "UK", 199.99m, true,1));
            orderInfo.Add(new OrderDetailsModel("1005", "BERGS", "Tim Adams", "Stockholm", "Sweden", 49.99m, true, 4));
            orderInfo.Add(new OrderDetailsModel("1006", "BLAUS", "Hanna Moos", "Mannheim", "Germany", 149.99m, true, 2));
            orderInfo.Add(new OrderDetailsModel("1007", "BLONP", "Andrew Fuller", "Strasbourg", "France", 99.99m, true,5));
            orderInfo.Add(new OrderDetailsModel("1008", "BOLID", "Martin King", "Madrid", "Spain", 499.99m, true,1));
            orderInfo.Add(new OrderDetailsModel("1009", "BONAP", "Lenny Lin", "Marseille", "France", 179.99m, true,1));
            orderInfo.Add(new OrderDetailsModel("1010", "BOTTM", "John Carter", "Toronto", "Canada", 79.99m, true,2));

            // Adding more rows to reach a total of 50 rows.
            for (int i = 11; i <= 50; i++)
            {
                orderInfo.Add(new OrderDetailsModel(
                    $"10{i:D2}",
                    $"CUST{i:D4}",
                    $"Customer {i}",
                    i % 2 == 0 ? "New York" : "Toronto",
                    i % 2 == 0 ? "USA" : "Canada",
                    199.99m + i,
                    i % 2 == 0,
                    i % 5 + 1
                ));
            }
        }
    }
}
