using riot.ws.infrastructure.dto;
using riot.ws.shared.api;

namespace riot.ws.service.handlers.Account.GetAccount
{
    public class GetAccountRiot : AbstractEndpoint
    {
        private string path = "https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/";
        public GetAccountRiot(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<AccountDto> GetAccountByGameName(String gameName, String tagLine)
        {
            path += $"{gameName}/{tagLine}";
            return await DoCallAsync<AccountDto>(path, HttpMethod.Get);
        }


    }
}
