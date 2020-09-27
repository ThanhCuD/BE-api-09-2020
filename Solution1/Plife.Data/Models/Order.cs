using System;
using System.Collections.Generic;

namespace PLife.Data.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
