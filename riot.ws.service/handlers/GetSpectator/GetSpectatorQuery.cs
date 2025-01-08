
using MediatR;

namespace riot.ws.service.handlers.GetSpectator
{
    public class GetSpectatorQuery : IRequest<GetSpectatorResponse>
    {
        public string Puuid { get; set; }

    }
}
