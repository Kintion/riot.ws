

using MediatR;

namespace riot.ws.service.handlers.Champion
{
    public class GetChampionMasteryQuery : IRequest<List<GetChampionMasteryResponse>>
    {
        public string GameName { get; set; }
        public string TagLine { get; set; }

    }
}
