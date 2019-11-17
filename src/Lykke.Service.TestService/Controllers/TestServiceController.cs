using System;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Lykke.Service.TestService.Client;
using Lykke.Service.TestService.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lykke.Service.TestService.Controllers
{
    [Route("api/TestService")] // TODO fix route
    public class TestServiceController : Controller, ITestServiceApi
    {
        private readonly IMapper _mapper;
        private readonly IHelloLogic _logic;

        public TestServiceController(IMapper mapper, IHelloLogic logic)
        {
            _mapper = mapper;
            _logic = logic;
        }

        [HttpGet(template: "Hello")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<string> Get()
        {
            return await _logic.SayHello();
        } 
    }
}
