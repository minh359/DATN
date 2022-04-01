using BlazorChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Services
{
    public interface IBoxChatServices
    {
        Task<IEnumerable<BoxChatViewModel>> GetListBoxChat();
    }
}
