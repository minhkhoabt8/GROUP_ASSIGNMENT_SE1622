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
        private FStoreDBContext dBContext = new FStoreDBContext();
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


        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            FStoreDBContext context = new FStoreDBContext();
            var orderDetails = context.OrderDetails.ToList();
            return orderDetails;
        }

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

        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var product = dBContext.Products.FirstOrDefault(p => p.ProductId == orderDetail.ProductId);
                if (product != null)
                {
                    dBContext.OrderDetails.Add(orderDetail);
                    dBContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Product Not Found");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void DeleteOrderDetail(int orderID, int productID)
        {
            var order = dBContext.OrderDetails.Where(o => o.OrderId == orderID && o.ProductId == productID);
            dBContext.Remove(order);
            dBContext.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {

            var order = dBContext.OrderDetails.Where(o => o.OrderId == orderDetail.OrderId && o.ProductId == orderDetail.ProductId);
            if (order != null)
            {
                var newOrder = new OrderDetail
                {
                    OrderId = orderDetail.OrderId,
                    ProductId = orderDetail.ProductId,
                    Discount = orderDetail.Discount,
                    Quantity = orderDetail.Quantity,
                    UnitPrice = orderDetail.UnitPrice
                };
                dBContext.OrderDetails.Update(newOrder);
                dBContext.SaveChanges();
            }
        }


    }
}
