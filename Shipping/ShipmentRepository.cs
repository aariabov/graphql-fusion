namespace Shipping;

public static class ShipmentRepository
{
    private static readonly List<Shipment> Shipments =
    [
        new Shipment { Id = 1, ProductId = 1, TrackingNumber = "SH-001", Status = "Delivered" },
        new Shipment { Id = 2, ProductId = 1, TrackingNumber = "SH-002", Status = "In Transit" },
        new Shipment { Id = 3, ProductId = 2, TrackingNumber = "SH-003", Status = "Shipped" },
    ];

    public static Shipment? GetById(int id)
        => Shipments.FirstOrDefault(s => s.Id == id);

    public static List<Shipment> GetByProductId(int productId)
        => Shipments.Where(s => s.ProductId == productId).ToList();
}