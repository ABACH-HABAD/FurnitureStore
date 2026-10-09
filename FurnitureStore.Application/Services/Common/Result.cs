namespace FurnitureStore.Application.Services.Common;

public class Result
{
    public bool IsSuccess { get; private set; }
    public string? Message { get; private set; }

    protected Result(bool success, string? message)
    {
        IsSuccess = success;
        Message = message;
    }

    public static Result Success()
    {
        return new Result(true, null);
    }

    public static Result Fail(string message)
    {
        return new Result(false, message);
    }
}

public class Result<T> : Result
{
    public T? Data { get; private set; }

    private Result(bool success, string? message, T? data) : base(success, message)
    {
        Data = data;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(true, null, data);
    }

    public static new Result<T> Fail(string message)
    {
        return new Result<T>(false, message, default);
    }
}