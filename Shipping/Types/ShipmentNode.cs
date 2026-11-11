using HotChocolate.Types;

namespace Shipping;

[ObjectType<Shipment>]
public static partial class ShipmentNode
{
    [BindMember(nameof(Shipment.ProductId))]
    public static Product GetProduct([Parent] Shipment shipment)
        => new(shipment.ProductId);
}