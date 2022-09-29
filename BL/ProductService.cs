using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductService
    {
        //injection to Data access layer (DAL)
        public ProductDal productDal { get; set; }
        public ProductService()
        {
            productDal = new ProductDal();
        }

        public List<Product> getAll()
        {
            return productDal.GetAllProducts();

        }

        public Product getById(int id)
        {
            return productDal.getById(id);
        }

        public void add(Product product)
        {
            productDal.addToProduct(product);
        }

        public List<Product> getByCategory(Category category)
        {
            List<Product> result = new List<Product>();
            foreach(var product in productDal.GetAllProducts())
            {
                if (product.categoryI==category.Id)
                {
                    result.Add(product);
                }
            }
            return result;
        }

    }
}
