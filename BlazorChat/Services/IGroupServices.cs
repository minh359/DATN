using BlazorChat.ViewModels;
using BlazorChatShared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Services
{
    public interface IGroupServices
    {
        Task<IEnumerable<GroupViewModel>> GetListGroup();
        Task<string> AddGroup([FromBody] AddGroupModel model);
    }
}
