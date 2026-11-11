namespace Shipping;

public class Shipment
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public required string TrackingNumber { get; set; }

    public required string Status { get; set; }
}