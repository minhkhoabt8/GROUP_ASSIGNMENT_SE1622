using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        //code below here

        public IEnumerable<Product> GetProducts()
        {
            //List<Product> products;
            try
            {
                using FStoreDBContext dBContext = new FStoreDBContext();
                var products = dBContext.Products.ToList();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //return products;
            return null;
        }//end GetProducts

        public void AddNewProduct(Product product)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                myContext.Products.Add(product);
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end InsertProduct

        public void DeleteProduct(int productID)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                var p = myContext.Products.SingleOrDefault(c => c.ProductId == productID);
                myContext.Products.Remove(p);
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//end DeleteProduct

        public void UpdateProduct(Product product)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                myContext.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    


    public IEnumerable<Product> FilterProductsByUnitPrice(int fromValue, int toValue)
        {
            try
            {
                using FStoreDBContext dBContext = new FStoreDBContext();
                if (fromValue > toValue)
                {
                    var products = dBContext.Products.Where(p => p.UnitPrice >= toValue && p.UnitPrice <= fromValue);
                    return products.OrderByDescending(p=>p.UnitPrice).ToList();
                }
                else if (fromValue < toValue)
                {
                    var products = dBContext.Products.Where(p => p.UnitPrice >= fromValue && p.UnitPrice <= toValue).ToList();
                    return products;
                    
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

    }
}
