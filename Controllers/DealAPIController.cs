using CGMMiddleWare.Models;
using CGMMiddleWare.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CGMMiddleWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealAPIController : ControllerBase
    {
        private readonly IDealRepository _dealRepository;

        public DealAPIController(IDealRepository dealRepository)
        {
            _dealRepository = dealRepository;
        }

        CancellationTokenSource tokensource = new CancellationTokenSource(TimeSpan.FromSeconds(1000));

        [Authorize]
        [HttpGet("GetAllDeals")]
        public async Task<ActionResult> GetAllDeals()
        {
            using (tokensource)
            {
                try
                {
                    var token = tokensource.Token;
                    List<Deal>? getallDeals = await _dealRepository.GetAllDealsAsync(token);
                    if (token.IsCancellationRequested)
                    {
                        // Clean up or return early if cancellation has been requested
                        Console.WriteLine("Cancellation requested. Stopping operation.");
                        return StatusCode(500, "Operation canceled.");
                    }
                    Console.WriteLine("Operation completed.");
                    return Ok(getallDeals);
                }
                catch (OperationCanceledException ex)
                {
                    // Handle cancellation exception if needed
                    Console.WriteLine("Operation canceled: " + ex.Message);
                    return StatusCode(500, "Operation canceled.");
                }
            }

        }

        [Authorize]
        [HttpGet("GetTopDeals")]
        public async Task<ActionResult> GetopenDeals()
        {
            using(tokensource)
            {
                try
                {
                    var token = tokensource.Token;
                    List<Deal>? gettop10deals = await _dealRepository.GetOpenDealsAsync(token);
                    if (token.IsCancellationRequested)
                    {
                        // Clean up or return early if cancellation has been requested
                        Console.WriteLine("Cancellation requested. Stopping operation.");
                        return StatusCode(500, "Operation canceled.");
                    }
                    Console.WriteLine("Operation completed.");
                    return Ok(gettop10deals);
                }
                catch (OperationCanceledException ex)
                {
                    // Handle cancellation exception if needed
                    Console.WriteLine("Operation canceled: " + ex.Message);
                    return StatusCode(500, "Operation canceled.");
                }
                catch(Exception ex)
                {
                    var innerException = ex.InnerException != null ? ex.InnerException.Message : String.Empty;
                    var responseString = $"Error occurred in authentication: {ex.Message} {innerException}.";
                    return StatusCode(500, responseString);
                }
            }
        }

    }
}
