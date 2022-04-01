using BlazorChat.Component;
using BlazorChat.Services;
using BlazorChat.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Pages
{
    public partial class ListGroup:ComponentBase
    {
        private bool Basic_CheckBox2 { get; set; }
        private List<AccountViewModel> accounts=null;
        private List<GroupViewModel> groups=null;
        [Inject] private IDialogService DialogService { get; set; }

        [Inject] private IGroupServices GroupServices { get; set; }
        [Inject] private IAccountServices AccountServices { get; set; }
        protected override async Task OnInitializedAsync()
        {
            groups = (List<GroupViewModel>)await GroupServices.GetListGroup();
        }
        protected async Task GetListAccInGroup(int grp_id)
        {
            accounts = (List<AccountViewModel>)await AccountServices.GetListAccountInGroup(grp_id);
        }
        private void AddGroup()
        {
            DialogService.Show<DialogAddGroup>("",null,null);
        }
    }
}
