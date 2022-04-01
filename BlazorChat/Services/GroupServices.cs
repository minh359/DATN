using BlazorChat.ViewModels;
using BlazorChatShared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorChat.Services
{
    public class GroupServices : IGroupServices
    {
        private readonly HttpClient httpClient;
        public GroupServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        [HttpPost]
        public async Task<string> AddGroup([FromBody] AddGroupModel model)
        {
            var result = await httpClient.PostAsJsonAsync<AddGroupModel>("/group/add",model);
            return result.Content.ToString();
        }

        public async Task<IEnumerable<GroupViewModel>> GetListGroup()
        {
            var result = await httpClient.GetFromJsonAsync<List<GroupViewModel>>("/group");
            return result;
        }
    }
}
