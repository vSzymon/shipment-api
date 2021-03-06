using Microsoft.AspNetCore.Mvc;
using shipment_api.Packages.Commands;
using System.Threading.Tasks;

namespace shipment_api.Controllers
{
    public class PackageController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreatePackageCommand command) =>
            Ok( await Sender.Send(command) );
    }
}
