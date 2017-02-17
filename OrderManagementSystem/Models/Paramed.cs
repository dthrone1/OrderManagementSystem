using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.Models
{
    public class Paramed:Order
    {
        public OrderTypes OrderType { get; set; }
    }
    public enum OrderTypes
    {
        Paramed,
        CreditCheck,
        CriminalReport
    }
}