namespace Shipping.Domain.Driver;

public class Driver
{
    public Guid Id { get; set; }
    public Guid VehicleId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }
    public double Salary { get; set; }

    public string Fio => $"{FirstName} {LastName}";
}