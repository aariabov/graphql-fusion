namespace Reviews;

using HotChocolate.CostAnalysis.Types;

[QueryType]
public static partial class ReviewQueries
{
    [Lookup]
    public static Review? GetReviewById(int id)
        => ReviewRepository.GetById(id);

    [ListSize(AssumedSize = 4)]
    public static List<Review> GetReviews()
        => ReviewRepository.GetAll();
}
