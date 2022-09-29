using BL;
using Entities;

public class Program
{
    public static ProductService productService = new ProductService();
    public static CategoryService categoryService = new CategoryService();

    public static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO THE SHOPPING APPP!!!!!");
        Console.WriteLine("PLEASE INSERT SMTH");
        Console.WriteLine("1 - get all the devices, 2 -get categorized phones , 3- tvs");
        operationScreen(int.Parse(Console.ReadLine()));

        Console.ReadKey();

    }

    public static void operationScreen (int id)
    {
        int commandID = id;

        if (commandID == 1)
            getAllProducts();
        
        if (commandID == 2)
            getBycategoryScreen((int)CategoryEnum.Phone);
        
        if (commandID == 3)
            getBycategoryScreen((int)CategoryEnum.Tv);

    }

    public static void getAllProducts() // screen that gets all the products
    {
        List<Product> allProducts = productService.getAll();

        foreach(var product in allProducts)

        {
            Console.WriteLine(String.Format("name: {0}, id: {1}, desc: {2} ", product.name,product.iD,product.desc));
        }
    }

    public static void getBycategoryScreen(int categoryId)
    {
        Category categoryForFilter = categoryService.getById(categoryId);
        List<Product> filteredProducts = productService.getByCategory(categoryForFilter);
        foreach(var product in filteredProducts)
        {
            Console.WriteLine(String.Format("name: {0}, id: {1}, desc: {2} ", product.name, product.iD, product.desc));
        }

    } //categorizes
}