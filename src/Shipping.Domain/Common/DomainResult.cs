namespace Shipping.Domain.Common;

public class DomainResult<T>
{
    private DomainResult(T data, bool isSuccess)
    {
        Data = data;
        IsSuccess = isSuccess;
    }

    private DomainResult(string message)
    {
        ErrorMessage = message;
    }

    public T Data { get; }
    public bool IsSuccess { get; }
    public string ErrorMessage { get; }

    public static DomainResult<T> Ok(T data)
    {
        return new DomainResult<T>(data: data, isSuccess: true);
    }

    public static DomainResult<T?> Fail(string message)
    {
        return new DomainResult<T?>(message: message);
    }
}