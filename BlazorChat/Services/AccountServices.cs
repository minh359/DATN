using BlazorChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BlazorChat.Services
{
    public class AccountServices :IAccountServices
    {
        private readonly HttpClient httpClient;

        public AccountServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<AccountViewModel>> GetListAccount()
        {
            var result= await httpClient.GetFromJsonAsync<List<AccountViewModel>>("/acc");
            return result;
        }
        public async Task<IEnumerable<AccountViewModel>> GetListAccountInGroup(int grp_id)
        {
            var result = await httpClient.GetFromJsonAsync<List<AccountViewModel>>("/acc/grp?grp_id="+grp_id);
            return result;
        }
    }
}
