namespace Reviews;

[QueryType]
public static partial class ProductQueries
{
    [Lookup, Internal] // Lookup поиск продукта, Internal - прячем от клиента
    public static Product? GetProductById(int id)
        => new(id);
}