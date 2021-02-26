using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpNews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueTaskVSTaskController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        public ValueTaskVSTaskController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        [Route("valueTask")]
        public async IActionResult GetValueTask()
        {
            bool hasData = _cache.TryGetValue("Value", out int value);

            if (!hasData)
            {
                GetVal
            }

            return Ok(value);
        }

        [HttpGet]
        [Route("task")]
        public async IActionResult GetTask()
        {

        }

        private ValueTask<int> GetValueByValueTask()
        {
            Task<int> value = LongActionAsync();
            var res = new ValueTask<int>(value);
            return value;
        }

        private async Task<int> GetValueByTaskAsync()
        {
            int value = await LongActionAsync();
            return value;
        }

        private async Task<int> LongActionAsync()
        {
            await Task.Delay(1000);
            return 5;
        }
    }
}
