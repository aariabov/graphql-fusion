using HotChocolate.Types;

namespace Reviews;

[ObjectType<Review>]
public static partial class ReviewNode
{
    [BindMember(nameof(Review.ProductId))]
    public static Product GetProduct([Parent] Review review)
        => new(review.ProductId);
}