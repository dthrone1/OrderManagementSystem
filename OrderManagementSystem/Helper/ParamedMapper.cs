using OrderManagementSystem.Core.Data;
using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.Helper
{
    public class ParamedMapper
    {
        public Paramed MaptoParamedModel(ParamedOrder order)
        {
            var paramed = new Paramed();
            paramed.OrderId = order.OrderId;
            paramed.CustomerName = order.CustomerName;
            paramed.AccountNumber = order.AccountNumber;
            paramed.ServiceCount = order.ServiceCount;

            return paramed;
        }
    }
}