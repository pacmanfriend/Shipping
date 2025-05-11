namespace Shipping.Domain.Vehicle;

public interface IVehiclesRepository
{
    public Task<List<Vehicle>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task<Guid> CreateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default);
    public Task UpdateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default);
    public Task DeleteVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default);
}