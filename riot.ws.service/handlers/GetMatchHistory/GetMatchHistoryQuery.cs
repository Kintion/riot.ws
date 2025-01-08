

using MediatR;

namespace riot.ws.service.handlers.GetMatchHistory
{
    public class GetMatchHistoryQuery : IRequest<GetMatchHistoryResponse>
    {
        public string Puuid {  get; set; }
        public bool Update {  get; set; }
    }
}
