using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.GetRank;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class RankController : RoutedControllerBase
    {
        private readonly ISender _sender;

        public RankController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        [Route("{summonerId}")]
        public virtual async Task<ActionResult> AccountbByNickname(string summonerId)
        {
            GetRankQuery command = new GetRankQuery
            {
                SummonerId = summonerId,
            };

            var account = await _sender.Send(command);
            return Ok(account);
        }
    }
}
