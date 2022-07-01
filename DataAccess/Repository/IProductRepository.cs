using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int productID);
        void AddNewProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);


    }
}
