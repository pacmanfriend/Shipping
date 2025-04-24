namespace Shipping.Domain.Common;

public class Result<T>
{
    private Result(T data, bool isSuccess)
    {
        Data = data;
        IsSuccess = isSuccess;
    }

    private Result(string message)
    {
        ErrorMessage = message;
    }

    public T Data { get; }
    public bool IsSuccess { get; }
    public string ErrorMessage { get; }

    public static Result<T> Ok(T data)
    {
        return new Result<T>(data: data, isSuccess: true);
    }

    public static Result<T?> Fail(string message)
    {
        return new Result<T?>(message: message);
    }
}