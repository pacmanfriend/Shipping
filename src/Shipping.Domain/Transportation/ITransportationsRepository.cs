namespace Shipping.Domain.Transportation;

public interface ITransportationsRepository
{
    public Task<List<Transportation>> GetTransportationsAsync(CancellationToken cancellationToken = default);
    public Task CreateTransportationAsync(Transportation transportation, CancellationToken cancellationToken = default);
}