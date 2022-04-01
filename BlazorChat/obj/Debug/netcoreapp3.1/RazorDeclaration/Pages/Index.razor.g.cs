// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using BlazorChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using BlazorChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using BlazorChat.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\Index.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\Index.razor"
       
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    private IEnumerable<string> PasswordStrength(string pw)
    {
        if (string.IsNullOrWhiteSpace(pw))
        {
            yield return "Password is required!";
            yield break;
        }
        if (pw.Length < 8)
            yield return "Password must be at least of length 8";
        if (!Regex.IsMatch(pw, @"[A-Z]"))
            yield return "Password must contain at least one capital letter";
        if (!Regex.IsMatch(pw, @"[a-z]"))
            yield return "Password must contain at least one lowercase letter";
        if (!Regex.IsMatch(pw, @"[0-9]"))
            yield return "Password must contain at least one digit";
    }

    private string PasswordMatch(string arg)
    {
        if (pwField1.Value != arg)
            return "Passwords don't match";
        return null;
    }


    //file upload
    //IList<IBrowserFile> files = new List<IBrowserFile>();
    //private void UploadFiles(InputFileChangeEventArgs e)
    //{
    //    foreach (var file in e.GetMultipleFiles())
    //    {
    //        files.Add(file);
    //    }
    //    //TODO upload the files to the server
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
