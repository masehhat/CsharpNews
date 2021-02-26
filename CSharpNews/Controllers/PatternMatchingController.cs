using Microsoft.AspNetCore.Mvc;

namespace CSharpNews.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatternMatchingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get1()
        {
            object value = 6;
            int result = Sum(value);
            return Ok(result);
        }

        private int Sum(object value)
        {
            int sum = 0;

            switch (value)
            {

                case int number when number > 0:
                    sum += number;
                    break;

                case int number when number < 0:
                    sum += (number * -1);
                    break;

                case string:
                    sum += value.ToString().Length;
                    break;

                case object:
                    break;

                default:
                    break;
            }

            return sum;
        }
    }
}