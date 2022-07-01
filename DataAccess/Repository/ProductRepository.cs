using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddNewProduct(Product product)
        {
            ProductDAO.Instance.AddNewProduct(product);
        }

        public void DeleteProduct(int productID)
        {
            ProductDAO.Instance.DeleteProduct(productID);
        }

        public IEnumerable<Product> FilterProductsByUnitPrice(string fromValue, string toValue)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return ProductDAO.Instance.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.Instance.UpdateProduct(product);
        }
    }
}
