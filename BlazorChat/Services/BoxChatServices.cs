using BlazorChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorChat.Services
{
    public class BoxChatServices : IBoxChatServices
    {
        private readonly HttpClient httpClient;
        public BoxChatServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<BoxChatViewModel>> GetListBoxChat()
        {
            var result = await httpClient.GetFromJsonAsync<List<BoxChatViewModel>>("/box");
            return result;
        }
    }
}
