using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpNews.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TuplesAndDiscardsController : ControllerBase
    {
        private readonly ILogger<TuplesAndDiscardsController> _logger;

        public TuplesAndDiscardsController(ILogger<TuplesAndDiscardsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get1()
        {
            //(string name, long mobile) data = ("ali", 9124021677);
            //return Ok(data.name);

            // Anouther defining
            //(string name, long mobile) = ("ali", 9124021677);
            //return Ok(name);

            // Anouther defining
            string name = "ali";
            long mobile = 9124021677;
            var data = (name, mobile);
            return Ok(data.name);
        }

        [HttpGet("deconstruct")]
        public IActionResult Get2()
        {
            // attebd to constructor method
            //var sample = new DeconstructClassSample("ali", 9124021677);
            //return Ok(sample.Name);

            DeconstructClassSample sample = new DeconstructClassSample("ali", 9124021677);
            sample.Deconstruct(out string name, out long mobile);

            return Ok(name);
        }

        [HttpGet("deconstructAndDiscard")]
        public IActionResult Get3()
        {
            DeconstructClassSample sample = new DeconstructClassSample("ali", 9124021677);
            var (name, _) = sample;
            return Ok(name);
        }
    }
}