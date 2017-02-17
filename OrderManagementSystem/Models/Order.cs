using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.Models
{
    public abstract class Order
    {
        public decimal OrderId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> AccountNumber { get; set; }
        public Nullable<int> ServiceCount { get; set; }
    }
}