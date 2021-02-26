using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CSharpNews.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocalFunctionController : ControllerBase
    {
        [HttpGet]
        public void Main()
        {
            IEnumerable<int> xs = GetSequence(10000);

            foreach (var x in xs)
            {
                Console.Write($"{x} ");
            }
        }

        public static IEnumerable<int> GetSequence(int len)
        {
            if (len < 0 || len > 999)
                throw new ArgumentOutOfRangeException(nameof(len), "len  must be between 0 and 999.");

            return GetSequenceEnumerator();

            IEnumerable<int> GetSequenceEnumerator()
            {
                for (int i = 0; i <= len; i++)
                {
                    yield return i;
                }
            }
        }
    }
}