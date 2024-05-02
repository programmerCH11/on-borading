namespace RedLab_on_boarding.Data;

internal interface IDataRepository
{
    public Task<string> ReadAsync(CancellationToken cancellationToken);
}