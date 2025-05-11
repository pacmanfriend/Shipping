namespace Shipping.Domain.Transportation;

public class Transportation
{
    public Guid Id { get; set; }
    public Guid DriverId { get; set; }
    public Guid RouteId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public List<Cargo> Cargos { get; set; }
    public string ShippingStatus { get; set; }
    public DateTimeOffset DepartureDate { get; set; }
    public DateTimeOffset ArrivalDate { get; set; }
    public double TotalPrice { get; set; }
}