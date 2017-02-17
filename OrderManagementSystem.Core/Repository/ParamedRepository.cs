using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Core.Data;

namespace OrderManagementSystem.Core.Repository
{
    public class ParamedRepository : IParamedRepository
    {
        public IEnumerable<ParamedOrder> GetAllParamedOrder()
        {
            var paramedOrders = new List<ParamedOrder>();
            try
            {
                using (var db = new OrderManagementEntities())
                {
                    paramedOrders =  db.ParamedOrders.ToList();
                    paramedOrders = MockData.MockOrderData.MockedOrders().ToList();
                }
            }
            catch (Exception)
            {
                //To Do Error Logging
                //Assuming database fails return dummy data from here
                paramedOrders = MockData.MockOrderData.MockedOrders().ToList();


            }
            return paramedOrders;

        }

        public ParamedOrder GetParamedOrder(int id)
        {
            var paramedOrder = new ParamedOrder();
            try
            {
                using (var db = new OrderManagementEntities())
                {
                    paramedOrder = db.ParamedOrders.Where(x => x.OrderId == id).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                //To Do Error Logging
            }

            return paramedOrder;

        }

        public bool AddOrder(ParamedOrder order)
        {
            
            try
            {
                using (var db = new OrderManagementEntities())
                {
                    order.OrderId = GetNextId();
                    db.ParamedOrders.Add(order);
                }
                return true;
            }
            catch (Exception)
            {

                //To Do Error Logging
                return false;
            }
        }

        static int GetNextId()
        {
            try
            {
                OrderManagementEntities data = new OrderManagementEntities();
                var orders = data.ParamedOrders.ToList();

                return orders.OrderBy(o => o.OrderId).Last().OrderId + 1;
            }
            catch (Exception)
            {
                //To Do Log

                return 1;
            }

        }

        public bool CancelOrder(int orderId)
        {
            try
            {
                using (var db = new OrderManagementEntities())
                {
                    db.ParamedOrders.Remove(GetParamedOrder(orderId));
                }
                return true;
            }
            catch (Exception)
            {

                //To Do Error Logging
                return false;
            }

    }
    }
}
