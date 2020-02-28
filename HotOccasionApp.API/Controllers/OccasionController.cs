using HotOccasionApp.INFRASTRUCTURE.DTO;
using HotOccasionApp.INFRASTRUCTURE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotOccasionApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OccasionController : ControllerBase
    {
        private readonly ILogger<OccasionController> _logger;
        IOccasionService _service;

        public OccasionController(ILogger<OccasionController> logger, IOccasionService service)
        {
            _logger = logger;
            _service = service;
            _logger.LogInformation("helloo logger");
        }

        [HttpGet]
        public OccasionDTO GetOccasion()
        {
            _logger.LogInformation("GetOccasion fired");
            var test = _service.GetOccasionByID(2);
            return new OccasionDTO();
        }
    }
}
