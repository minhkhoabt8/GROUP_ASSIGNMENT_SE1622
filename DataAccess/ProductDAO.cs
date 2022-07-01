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

        public List<Product> GetProducts()
        {
            List<Product> products;
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                products = myContext.Products.ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }//end GetProducts

        public void AddNewProduct(Product product)
        {
            try
            {
                using FStoreDBContext myContext = new FStoreDBContext();
                myContext.Products.Add(product);
                myContext.SaveChanges();
            }catch (Exception ex)
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
    }
}
