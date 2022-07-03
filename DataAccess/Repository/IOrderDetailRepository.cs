using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetailsByID(int orderID);
        void AddNewOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderID, int productID);
        void UpdateOrderDetail(OrderDetail orderDetail);
    }
}
