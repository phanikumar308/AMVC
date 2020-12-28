using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private IRepoHelloWorld _repohelloworld;

        public HelloWorldController(IRepoHelloWorld repohelloworld)
        {
            _repohelloworld = repohelloworld;
        }
        [HttpGet("helloworld")]
        public async Task<List<string>> HelloWorld()
        {
            return await _repohelloworld.repohelloWorld();
        }
    }
}
