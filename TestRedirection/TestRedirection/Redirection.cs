using System.Net;

namespace TestRedirection;

public class Redirection
{
    public HttpStatusCode Code { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string? Title { get; set; }

    public int Size { get; set; }
}