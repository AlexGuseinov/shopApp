using Entities;
using Entities.LocalDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            return FakeDB.GetAllProducts();
        }

        public Product getById (int id)
        {
            Product result =new Product();

            foreach (var product in FakeDB.GetAllProducts())
            {
                if (product.iD==id)
                {
                    result = product;
                    break;
                }
            }
            return result;
        }

        public void addToProduct(Product product)
        {
            FakeDB.GetAllProducts().Add(product);
        }


    }
}
