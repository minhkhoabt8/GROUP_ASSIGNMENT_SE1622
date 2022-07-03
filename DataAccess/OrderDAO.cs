using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        // code below here
        public IEnumerable<Order> GetOrders()
        {
            //List<Order> orders;
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                var orders = myContext.Orders.ToList();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }//end GetOrders
        public void AddNewOrder(Order order)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                myContext.Orders.Add(order);
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end AddNewOrder
        public void DeleteOrder(int orderID)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                var p = myContext.Orders.SingleOrDefault(c => c.OrderId == orderID);
                myContext.Orders.Remove(p);
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end DeleteOrder
        public void UpdateOrder(Order order)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                myContext.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Order> GetOrderHistory(int memberId)
        {
            try
            {
                FStoreDBContext dBContext = new FStoreDBContext();
                var orders = dBContext.Orders.Where(o => o.MemberId == memberId).ToList();
                return orders;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
