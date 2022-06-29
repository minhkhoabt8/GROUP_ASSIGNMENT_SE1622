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
            throw new NotImplementedException();
        }

        public void DeleteOrderDetail(int orderID, int productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetOrderDetails(int orderID)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
