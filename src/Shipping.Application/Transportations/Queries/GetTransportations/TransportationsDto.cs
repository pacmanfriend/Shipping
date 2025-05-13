using Shipping.Domain.Transportation;

namespace Shipping.Application.Transportations.Queries.GetTransportations;

public class TransportationsDto
{
    public string RouteTitle { get; set; }
    public string DriverFio { get; set; }
    public double TotalPrice { get; set; }
    public DateTimeOffset DepartureDate { get; set; }
    public DateTimeOffset ArrivalDate { get; set; }
    public List<Cargo> Cargos { get; set; }
}