using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.Account.GetAccount;
using riot.ws.service.handlers.GetMatchHistory;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class MatchHistoryController : RoutedControllerBase
    {
        private readonly IMediator _mediator;
        public MatchHistoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{puuid}")]
        public virtual async Task<ActionResult> MatchHistoryByPuuid(string puuid, [FromQuery] bool update = false)
        {
            GetMatchHistoryQuery command = new GetMatchHistoryQuery
            {
                Puuid = puuid,
                Update = update
            };

            GetMatchHistoryResponse matchList = await _mediator.Send(command);
            return Ok(matchList.matches);
        }
    }
}
