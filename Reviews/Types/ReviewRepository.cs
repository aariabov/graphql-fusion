namespace Reviews;

public static class ReviewRepository
{
    private static readonly List<Review> Reviews =
    [
        new Review { Id = 1, Body = "Sturdy and well-built.", Stars = 5, ProductId = 1 },
        new Review { Id = 2, Body = "A bit wobbly.", Stars = 3, ProductId = 1 },
        new Review { Id = 3, Body = "Very comfortable!", Stars = 5, ProductId = 2 },
        new Review { Id = 4, Body = "Good value for the price.", Stars = 4, ProductId = 3 },
    ];

    public static Review? GetById(int id)
        => Reviews.FirstOrDefault(r => r.Id == id);

    public static List<Review> GetByProductId(int productId)
        => Reviews.Where(r => r.ProductId == productId).ToList();

    public static List<Review> GetAll()
        => Reviews;
}