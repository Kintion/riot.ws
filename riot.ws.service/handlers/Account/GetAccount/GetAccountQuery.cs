using MediatR;



namespace riot.ws.service.handlers.Account.GetAccount
{
    public class GetAccountQuery : IRequest<GetAccountQueryResponse>
    {
        public string GameName { get; set; }
        public string TagLine { get; set; }
        public bool? Update { get; set; }
    }




}