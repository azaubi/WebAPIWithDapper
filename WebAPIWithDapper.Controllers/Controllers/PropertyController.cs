using Microsoft.AspNetCore.Mvc;
using WebAPIWithDapper.Services;

namespace WebAPIWithDapper.Controllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly IPropertyService _propertyService;

        public PropertyController(ILogger<PropertyController> logger, IPropertyService propertyService)
        {
            _logger = logger;
            _propertyService = propertyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _propertyService.Get());
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, $"Error Encountered: {ex}");
                throw;
            }
            
        }
    }
}
