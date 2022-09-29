using Entities.LocalDB;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDal
    {
        public List<Category> GetAllProducts()
        {
            return FakeDB.GetAllCategories();
        }

        public Category getById(int id)
        {
            Category result = new Category();

            foreach (var product in FakeDB.GetAllCategories())
            {
                if (product.Id == id)
                {
                    result = product;
                    break;
                }
            }
            return result;
        }

        public void addToProduct(Category product)
        {
            FakeDB.GetAllCategories().Add(product);
        }

    }
}
