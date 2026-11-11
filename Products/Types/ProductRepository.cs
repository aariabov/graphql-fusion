namespace Products;

public static class ProductRepository
{
    private static readonly List<Product> Products =
    [
        new Product { Id = 1, Name = "Table", Price = 899.99 },
        new Product { Id = 2, Name = "Couch", Price = 1299.50 },
        new Product { Id = 3, Name = "Chair", Price = 54.00 },
    ];

    public static Product? GetById(int id)
        => Products.FirstOrDefault(p => p.Id == id);

    public static List<Product> GetAll()
        => Products;
}