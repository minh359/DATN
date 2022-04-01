#pragma checksum "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c9dd06f7d9833f5bfa542ae9bbaa9f34b50e724"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/list")]
    public partial class ListAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ListAccount</h3>\r\n");
#nullable restore
#line 4 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
 if (accounts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorChat.Component.LoadingIndicator>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 7 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th>ID</th>
                <th>Username</th>
                <th>Name</th>
                <th>Dob</th>
                <th>Email</th>
                <th>Country</th>
                <th>Icon</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 23 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
             foreach (var item in accounts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 26 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.AccountID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 27 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 28 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 29 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.Dob.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 30 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 31 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     item.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "th");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 33 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                     if (item.Status == "Online")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                        ");
            __builder.OpenComponent<MudBlazor.MudBadge>(35);
            __builder.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                         Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenComponent<MudBlazor.MudAvatar>(41);
                __builder2.AddAttribute(42, "Image", "https://www.pngall.com/wp-content/uploads/12/Avatar-Profile-Vector-PNG-Clipart.png");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 38 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                        ");
            __builder.OpenComponent<MudBlazor.MudBadge>(46);
            __builder.AddAttribute(47, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                         Color.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenComponent<MudBlazor.MudAvatar>(52);
                __builder2.AddAttribute(53, "Image", "https://media.istockphoto.com/vectors/user-icon-flat-isolated-on-white-background-user-symbol-vector-vector-id1300845620?k=20&m=1300845620&s=612x612&w=0&h=f4XTZDAv7NPuZbG0habSpU0sNgECM0X7nbKzTUta3n8=");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 44 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 47 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 50 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListAccount.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591