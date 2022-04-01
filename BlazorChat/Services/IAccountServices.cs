using BlazorChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Services
{
    public interface IAccountServices
    {
        Task<IEnumerable<AccountViewModel>> GetListAccount();
        Task<IEnumerable<AccountViewModel>> GetListAccountInGroup(int grp_id);
    }
}
