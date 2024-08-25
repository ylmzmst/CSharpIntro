internal class Program
{
    private static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category{CategoryID=1,CategoryName="bilgisayar"},
            new Category{CategoryID=2,CategoryName="telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product{ProductID=1,CategoryID=1,ProductName="lenovo",QuantityPerUnit="32 GB ram",UnitPrice=10000,UnitInStock=5},
            new Product{ProductID=2,CategoryID=1,ProductName="asus",QuantityPerUnit="16 GB ram",UnitPrice=8000,UnitInStock=3},
            new Product{ProductID=3,CategoryID=1,ProductName="hp",QuantityPerUnit="8 GB ram",UnitPrice=6000,UnitInStock=2},
            new Product{ProductID=4,CategoryID=2,ProductName="samsung",QuantityPerUnit="4 GB ram",UnitPrice=5000,UnitInStock=15},
            new Product{ProductID=5,CategoryID=2,ProductName="onvio",QuantityPerUnit="4 GB ram",UnitPrice=4000,UnitInStock=0},
        };

        Console.WriteLine("___Algoritmik___");
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        Console.WriteLine();

        Console.WriteLine("___Linq___");
        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        GetProducts(products);


        Console.ReadLine();
    }
    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }
    static List<Product> GetPtoductsLinq(List<Product> products)
    {
        return products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3).ToList();
    }
}

class Product
{
    public int ProductID { get; set; }
    public int CategoryID { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}

class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}