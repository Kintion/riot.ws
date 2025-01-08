using MediatR;


namespace riot.ws.service.handlers.Account.AddAccount
{
    public class AddAccountCommand : IRequest<AddAccountResponse>
    {
        public string Puuid { get; set; }
        public string GameName { get; set; }
        public string TagLine { get; set; }
    }
}
