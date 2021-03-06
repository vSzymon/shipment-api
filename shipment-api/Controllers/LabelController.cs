using Microsoft.AspNetCore.Mvc;
using shipment_api.Labels.Queries;
using System.Threading.Tasks;

namespace shipment_api.Controllers
{
    public class LabelController : ApiController
    {
        [HttpGet("trackingNumber")]
        public async Task<IActionResult> Get(string trackingNumber) =>
            Ok( await Sender.Send(new GetLabelQuery(trackingNumber)) );
        
    }
}
