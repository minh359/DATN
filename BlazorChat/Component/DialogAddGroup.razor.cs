using BlazorChat.Services;
using BlazorChat.ViewModels;
using BlazorChatShared.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.Component
{
    public partial class DialogAddGroup : ComponentBase
    {
        private List<AccountViewModel> accounts = null;
        string grp_name { get; set; }
        int grp_type { get; set; }
        private HashSet<int> lst_acc = new HashSet<int>();
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Inject] private IGroupServices GroupServices { get; set; }
        [Inject] private IAccountServices AccountServices { get; set; }
        protected override async Task OnInitializedAsync()
        {
            accounts = (List<AccountViewModel>)await AccountServices.GetListAccount();
        }
        private void Cancel()
        {
            MudDialog.Close(DialogResult.Cancel());
        }
        private async Task Add()
        {
            int b;
            AddGroupModel model = new AddGroupModel();
            List<int> acc = new List<int>();
            foreach (var item in lst_acc)
            {
                acc.Add(item);
            }
            model.grp_name = grp_name;
            model.grp_type = grp_type;
            model.lst_acc = acc;
            try
            {
                var result = await GroupServices.AddGroup(model);
                Snackbar.Add("A new group be added", Severity.Success);
                Snackbar.Add(result, Severity.Success);
                DialogResult.Ok(grp_name);
                MudDialog.Close(DialogResult.Ok(grp_name));
            }
            catch
            {
                Snackbar.Add("An error has occured. Try again later", Severity.Error);
                DialogResult.Ok(grp_name);
                MudDialog.Close(DialogResult.Ok(grp_name));
            }

        }
    }
}
