using OrderManagementSystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Core.Repository
{
    public interface IParamedRepository
    {
        IEnumerable<ParamedOrder> GetAllParamedOrder();
        ParamedOrder GetParamedOrder(int id);

        bool AddOrder(ParamedOrder order);
        bool CancelOrder(int orderId);
    }
}
