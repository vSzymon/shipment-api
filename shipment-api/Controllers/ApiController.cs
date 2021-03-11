﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace shipment_api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        private ISender _sender;
        public ISender Sender => _sender ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
