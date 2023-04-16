public static class Equality_Operators
{
    public static void Start()
    {
        //Equals();
        //ReferenceEquals();
        //Equal();
    }

    public static void Equals()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> Result = numbers.Where(num => num.Equals(5)).Select(num => num).ToList();

        foreach (int num in Result)
        {
            Console.WriteLine($"{num} ");
        }
    }

    public static void ReferenceEquals()
    {
        Product product = Product.GetAllProducts().FirstOrDefault();
        var referenceEqualsProducts = (from p in Product.GetAllProducts()
                                       where Object.ReferenceEquals(p.ProductName, product.ProductName)
                                       select p).ToList();

        referenceEqualsProducts.ForEach(p => { Console.WriteLine(p.ProductName); });
    }
    public static void Equal()//==
    {
        Product product = Product.GetAllProducts().FirstOrDefault();
        var referenceEqualsProducts = (from p in Product.GetAllProducts()
                                       where p.ProductName == product.ProductName
                                       select p).ToList();

        referenceEqualsProducts.ForEach(p => { Console.WriteLine(p.ProductName); });
    }
}

public class Product
{
    public string ProductName { get; set; }
    public int ProductID { get; set; }
    public static List<Product> GetAllProducts()
    {
        return new List<Product>()
        {
            new Product { ProductID = 1, ProductName = "Stul" },
            new Product { ProductID = 2, ProductName = "Komputer" },
            new Product { ProductID = 3, ProductName = "Quloqchin" },
            new Product { ProductID = 4, ProductName = "Sichqoncha" }
        };
    }
}