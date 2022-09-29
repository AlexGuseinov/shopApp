using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LocalDB
{
    public static class FakeDB
    {
        public static List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product() { iD = 1, name = "iphone 13", color = "black", price = 1300,desc="its a phone",categoryI=1 },
                new Product() { iD = 2, name = "iphone se", color = "silver", price = 1300,desc="its a phone",categoryI=1  },
                new Product() { iD = 3, name = "iphone 12", color = "blue", price = 700,desc="512gb" ,categoryI=1 },
                new Product() { iD = 4, name = "iphone 11", color = "white", price = 678,desc="64gb" ,categoryI=1 },
                new Product() { iD = 5, name = "iphone 13", color = "gold", price = 1200,desc="128gb" ,categoryI=1 },
                new Product() { iD = 6, name = "panasonic", color = "black", price = 1700,desc="hd 2k" ,categoryI=2 },
                new Product() { iD = 7, name = "LG", color = "black", price = 1999,desc="144 hz screen 6 " ,categoryI=2 },
                new Product() { iD = 7, name = "Samsung", color = "black", price = 1999,desc="full hd 4k" ,categoryI=2 },
            };
        }
        public static List<Category> GetAllCategories()
        {
            return new List<Category>()
            {
               new Category() {Id=1,Name="Phone"},
               new Category() {Id=2,Name="TV"},
            };
        }

    }
}
