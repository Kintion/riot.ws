using MediatR;
using Microsoft.AspNetCore.Mvc;
using riot.ws.service.handlers.Account.AddAccount;
using riot.ws.service.handlers.Account.GetAccount;
using RiotApiDb.Controllers;

namespace riot.ws.api.Controllers
{
    public class AccountController : RoutedControllerBase
    {

        private readonly IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpPost]
        //[Route("")]
        //public virtual async Task<ActionResult> NewAccount([FromBody] AddAccountCommand command)
        //{
        //    var account = await _mediator.Send(command);
        //    return Ok(account);
        //}

        [HttpGet]
        [Route("{gameName}/{tagLine}")]
        public virtual async Task<ActionResult> AccountbByNickname(string gameName, string tagLine, [FromQuery] bool update = false)
        {
            GetAccountQuery command = new GetAccountQuery
            {
                GameName = gameName,
                TagLine = tagLine,
                Update = update
            };

            var account = await _mediator.Send(command);
            return Ok(account);
        }

    }
}
