using Back.Interview.Domain;
using Back.Interview.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back.Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterviewController : ControllerBase
    {
        private readonly ILogger<InterviewController> _logger;
        private readonly IDataInterviewDomain _dataInterviewDomain;

        public InterviewController(ILogger<InterviewController> logger, IDataInterviewDomain dataInterviewDomain)
        {
            _logger = logger;
            _dataInterviewDomain = dataInterviewDomain;
        }

        [HttpGet(Name = "GetInterview")]
        public async Task<IActionResult> GetInterviewAsync()
        {
            _logger.LogInformation("Chegamos na controller e estamos no metodo GetInterviewAsync");
            var data = await _dataInterviewDomain.GetDataAsync();
            return Ok(data);
        }
    }
}
