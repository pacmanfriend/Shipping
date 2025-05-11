namespace Shipping.Domain.Vehicle;

public class Vehicle
{
    public Guid Id { get; set; }
    public string VehicleType { get; set; }
    public string LicensePlate { get; set; }
    public double Payload { get; set; }
    public double BodyVolume { get; set; }
    public string TechnicalCondition { get; set; }
    public DateTimeOffset LastServiceDate { get; set; }
    public double FuelConsumption { get; set; }
}