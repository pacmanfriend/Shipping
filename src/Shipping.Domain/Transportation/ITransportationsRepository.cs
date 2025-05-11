namespace Shipping.Domain.Transportation;

public interface ITransportationsRepository
{
    public Task<List<Transportation>> GetTransportations(CancellationToken cancellationToken = default);
    public Task CreateTransportation(Transportation transportation, CancellationToken cancellationToken = default);
}