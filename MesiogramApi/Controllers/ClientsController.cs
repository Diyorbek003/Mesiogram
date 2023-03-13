using MesiogramApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace MesiogramApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
     private readonly HubclientsService _hubclientsService;

        public ClientsController(HubclientsService hubclientsService)
        {
            _hubclientsService = hubclientsService;
        }

        [HttpGet]
        public IActionResult GetClients() =>Ok(_hubclientsService.Clients);
        
    }
}
