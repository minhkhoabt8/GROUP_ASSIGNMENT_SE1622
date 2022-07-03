using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        //code below here

        public IEnumerable<OrderDetail> GetOrderDetailsByID(int orderID)
        {

            try
            {
                FStoreDBContext context = new FStoreDBContext();
                var orderDetails = context.OrderDetails.Where(od => od.OrderId == orderID);
                return orderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
