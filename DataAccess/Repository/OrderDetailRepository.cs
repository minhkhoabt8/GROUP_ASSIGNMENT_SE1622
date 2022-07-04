using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
           OrderDetailDAO.Instance.AddNewOrderDetail(orderDetail);
        }

        public void DeleteOrderDetail(int orderID, int productID)
        {
            OrderDetailDAO.Instance.DeleteOrderDetail(orderID, productID);
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return OrderDetailDAO.Instance.GetOrderDetails();
        }

        public IEnumerable<OrderDetail> GetOrderDetailsByID(int orderID)
        {
            return OrderDetailDAO.Instance.GetOrderDetailsByID(orderID);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
        }
    }
}
