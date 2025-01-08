using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.Champion;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class ChampionController(ISender sender) : RoutedControllerBase
    {
        private readonly ISender _sender = sender;


        [HttpGet]
        [Route("{gameName}/{tagLine}")]
        public virtual async Task<ActionResult> ChampionMastery(string gameName, string tagLine)
        {
            var championList = await _sender.Send(new GetChampionMasteryQuery
            {
                GameName=gameName,
                TagLine=tagLine
            });
            return Ok(championList);
        }

    }
}
