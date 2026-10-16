using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Backend;

public class Function1
{
  private readonly ILogger<Function1> _logger;

  public Function1(ILogger<Function1> logger)
  {
    _logger = logger;
  }


  [Function("GetBooks")]
  public IActionResult Run(
      [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "books")] HttpRequest req)
  {
    var books = new[]
    {
            new { title = "The Hobbit", author = "J.R.R. Tolkien", year = 1937 },
            new { title = "Dune", author = "Frank Herbert", year = 1965 },
            new { title = "The Left Hand of Darkness", author = "Ursula K. Le Guin", year = 1969 },
            new { title = "Project Hail Mary", author = "Andy Weir", year = 2021 }
        };
    return new OkObjectResult(books);
  }
}
