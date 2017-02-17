using OrderManagementSystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Core.MockData
{
    public static class MockOrderData
    {
        public static IEnumerable<ParamedOrder> MockedOrders()
        {
            var lst = new List<ParamedOrder>
            {
                new ParamedOrder {OrderId = 100, AccountNumber =1,CustomerName = "TestCustomer#1",ServiceCount = 2 },
                new ParamedOrder {OrderId = 101, AccountNumber =0,CustomerName = "TestCustomer#2",ServiceCount = 3 },
                new ParamedOrder {OrderId = 102, AccountNumber =2,CustomerName = "TestCustomer#3",ServiceCount = 1 }
            };

            return lst;
        }
    }
}
