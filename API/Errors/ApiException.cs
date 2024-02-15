namespace API.Errors;

public class ApiException
{
        private readonly int statusCode;
        private readonly string message;
        private readonly string details;
    public ApiException(int statusCode, string message, string details)
    {
            this.details = details;
            this.message = message;
            this.statusCode = statusCode;
        StatusCode = statusCode;
        Message = message;
        Details = details;
    }

    public int StatusCode { get; set; }

    public string Message { get; set; }

    public string Details { get; set; }
}
