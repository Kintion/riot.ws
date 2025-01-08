using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.GetSpectator;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class SpectatorController : RoutedControllerBase
    {
        private readonly IMediator _mediator;

        public SpectatorController(IMediator mediator) {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public virtual async Task<ActionResult> Spectator(string gameName, string tagLine)
        {
            var spectator = await _mediator.Send(new GetSpectatorQuery
            {
                Puuid = ""
            });
            return Ok(spectator);
        }
    }
}
