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
        private static FStoreDBContext dbContext = new FStoreDBContext();
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
                var products = dbContext.Products.ToList();
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
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
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
                var p = dbContext.Products.SingleOrDefault(c => c.ProductId == productID);
                dbContext.Products.Remove(p);
                dbContext.SaveChanges();
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
                dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
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
                
                if (fromValue > toValue)
                {
                    var products = dbContext.Products.Where(p => p.UnitPrice >= toValue && p.UnitPrice <= fromValue);
                    return products.OrderByDescending(p=>p.UnitPrice).ToList();
                }
                else if (fromValue < toValue)
                {
                    var products = dbContext.Products.Where(p => p.UnitPrice >= fromValue && p.UnitPrice <= toValue).ToList();
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
