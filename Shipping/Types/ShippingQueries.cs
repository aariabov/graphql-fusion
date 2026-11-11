namespace Shipping;

[QueryType]
public static partial class ShippingQueries
{
    [Lookup]
    public static Shipment? GetShipmentById(int id)
        => ShipmentRepository.GetById(id);

    [Internal, Lookup]
    public static Product? GetProductById(int id)
        => new(id);
}