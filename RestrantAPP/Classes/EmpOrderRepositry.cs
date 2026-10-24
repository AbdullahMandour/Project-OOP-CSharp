using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public class EmpOrderRepositry : IRepositry<CLSOrder>
    {
        //List to store
        private List<CLSOrder> DatatOrders = new List<CLSOrder>();

        public bool Add(CLSOrder entity)
        {
            DatatOrders.Add(entity);
            return true;


        }

        public bool Delete(int id)
        {
            var order = GetById(id);
            if (order != null)
            {
                DatatOrders.Remove(order);
                return true;
            }
            return false;

        }

        public bool Edit(CLSOrder entity)
        {
            var oldOrder = GetById(entity.OrderId);
            if (oldOrder != null)
            {
                // Update the properties of the old order with the new values from the entity
                // Reference type

                oldOrder.ClintId = entity.ClintId;
                oldOrder.RestrantId = entity.RestrantId;
                oldOrder.OrderDetalis = entity.OrderDetalis;
                oldOrder.TotalPrice = entity.TotalPrice;
                oldOrder.OrderDate = entity.OrderDate;
                oldOrder.Status = entity.Status;
                return true;
            }

            return false;


        }

        public List<CLSOrder> GetAll()
        {

            return DatatOrders;
        }

        public CLSOrder GetById(int id)
        {
            foreach(var item in DatatOrders)
            {
                if(item.OrderId == id)
                {
                    return item;
                }
            }
            return null;
        }
    
    public bool ChangeOrderStatus(int orderId, OrderStatus newStatus )
        {
            var order = GetById(orderId);
            if (order != null)
            {
                order.Status = newStatus;
                return true;
            }
            return false;
        }
    }
}
