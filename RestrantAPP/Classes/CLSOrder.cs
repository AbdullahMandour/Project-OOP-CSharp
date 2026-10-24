using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrantAPP.Classes
{
    public enum OrderStatus
    {
        Pending,
        Approved,
        Rejected,
        Delivery,
        Canceled
    }
    public class CLSOrder
    {
        public int OrderId { get; set; }
        public int ClintId { get; set; }
        public int RestrantId { get; set; }

        private string _orderDetails;
        public string OrderDetalis // (بنفس الاسبيلنج بتاعك)
        {
            get { return _orderDetails; }
            set
            {
                if (ValidationHelper.IsValidString(value))
                    _orderDetails = value;
                else
                    _orderDetails = "No_Details_Provided";
            }
        }
        public OrderStatus Status { get; set; }=OrderStatus.Pending;
       
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        //Constractor
        public CLSOrder(int orderId, int clintId, int restrantId, string orderDetalis, decimal totalPrice)
        {
            OrderId = orderId;
            ClintId = clintId;
            RestrantId = restrantId;
            OrderDetalis = orderDetalis;
            TotalPrice = totalPrice;
            OrderDate =DateTime.Now;
           
        }

        public void PrintOrder()
        {
            // Implement print order logic here
            Console.WriteLine("=======================================");
            Console.WriteLine($"Order Number: {OrderId}");
            Console.WriteLine($"Date: {OrderDate}");
            Console.WriteLine($"Client ID: {ClintId} | Restaurant ID: {RestrantId}");
            Console.WriteLine($"Order Details: {OrderDetalis}");
            Console.WriteLine($"Total Price: {TotalPrice} EGP");
            Console.WriteLine($"Status: [{Status}]");
            Console.WriteLine("=======================================");
        }

    }
}
