namespace Products;

using HotChocolate.CostAnalysis.Types;

[QueryType]
public static partial class ProductQueries
{
    [Lookup]
    public static Product? GetProductById(int id)
        => ProductRepository.GetById(id);

    [ListSize(AssumedSize = 3)]
    public static List<Product> GetProducts()
        => ProductRepository.GetAll();
}
