using HotChocolate.CostAnalysis.Types;

namespace Shipping;

public sealed record Product(int Id)
{
    [ListSize(AssumedSize = 2)]
    public List<Shipment> GetShipments()
        => ShipmentRepository.GetByProductId(Id);
}