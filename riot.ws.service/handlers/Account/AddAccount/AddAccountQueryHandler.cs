using MediatR;
using riot.ws.domain.Context;
using riot.ws.domain.Models;


namespace riot.ws.service.handlers.Account.AddAccount
{
    public class AddAccountQueryHandler : IRequestHandler<AddAccountCommand, AddAccountResponse>
    {
        private readonly PostgresContext _context;

        public AddAccountQueryHandler(PostgresContext context)
        {
            _context = context;
        }

        public async Task<AddAccountResponse> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
            SummonerAccount newSummoner = new SummonerAccount
            {
                Puuid = request.Puuid,
                Gamename = request.GameName,
                Tagline = request.TagLine
            };

            _context.SummonerAccounts.Add(newSummoner);

            await _context.SaveChangesAsync();

            return new AddAccountResponse
            {
                GameName = request.GameName,
                Puuid = request.Puuid,
                TagLine = request.TagLine
            };
        }
    }
}
