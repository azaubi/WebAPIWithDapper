using Microsoft.AspNetCore.Mvc;
using WebAPIWithDapper.Services.Services;

namespace WebAPIWithDapper.Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidentController : ControllerBase
    {
        private readonly ILogger<ResidentController> _logger;
        private readonly IResidentService _residentService;

        public ResidentController(ILogger<ResidentController> logger, IResidentService residentService)
        {
            _logger = logger;
            _residentService = residentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _residentService.Get());
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, $"Error Encountered: {ex}");
                throw;
            }

        }
    }
}
