namespace Shipping.Domain.Transportation;

public interface ICargosRepository
{
    public Task<List<Cargo>> GetByTransportation(Guid transportationId, CancellationToken cancellationToken = default);
    public Task CreateCargo(Cargo cargo, CancellationToken cancellationToken = default);
    public Task DeleteCargo(Guid cargoId, CancellationToken cancellationToken = default);
}