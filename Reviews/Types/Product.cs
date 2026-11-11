namespace Reviews;

using HotChocolate.CostAnalysis.Types;

// добавляем продуктам отзывы - в общей схеме клиент будет видеть атрибуты продукта: id, name, price и отзывы
public sealed record Product(int Id)
{
    [ListSize(AssumedSize = 2)]
    public List<Review> GetReviews()
        => ReviewRepository.GetByProductId(Id);
}
