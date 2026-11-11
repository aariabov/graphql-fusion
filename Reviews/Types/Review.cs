namespace Reviews;

public class Review
{
    public int Id { get; set; }

    public required string Body { get; set; }

    public int Stars { get; set; }

    public int ProductId { get; set; }
}