using System.Text;

namespace RedLab_on_boarding.Data;

internal sealed class FileRepository : IDataRepository, IDisposable
{
    private readonly FileStream _stream;
    private bool _disposed;

    public FileRepository(string path, FileMode mode)
    {
        _stream = new FileStream(path, mode);
    }

    public async Task<string> ReadAsync(CancellationToken cancellationToken)
    {
        var buffer = new byte[_stream.Length];
        await _stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken);

        return Encoding.Default.GetString(buffer);
    }

    public void Dispose()
    {
        if(_disposed) return;

        _stream.Dispose();
        GC.SuppressFinalize(this);
        _disposed = true;
    }
}