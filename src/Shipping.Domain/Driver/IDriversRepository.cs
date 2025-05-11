namespace Shipping.Domain.Driver;

public interface IDriversRepository
{
    public Task<List<Driver>> GetAllAsync(CancellationToken cancellationToken = default);
    public Task CreateDriverAsync(Driver driver, CancellationToken cancellationToken = default);
}