using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorChat.Services;
using BlazorChat.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorChat.Pages
{
    public partial class ListAccount : ComponentBase
    {
        private List<AccountViewModel> accounts;
        [Inject] private IAccountServices services { get; set; }
        protected override async Task OnInitializedAsync()
        {
            accounts = (List<AccountViewModel>)await services.GetListAccount();
        }
    }
}
