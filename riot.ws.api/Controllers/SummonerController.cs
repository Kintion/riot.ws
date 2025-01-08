using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.GetSummoner;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class SummonerController : RoutedControllerBase
    {
        private readonly ISender _sender;

        public SummonerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        [Route("{gameName}/{tagLine}")]
        public virtual async Task<ActionResult> Summoner(string gameName, string tagLine)
        {
            var summoner = await _sender.Send(new GetSummonerQuery
            {
                Puuid = gameName,
            });
            return Ok(summoner);
        }
    }
}
