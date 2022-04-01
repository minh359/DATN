#pragma checksum "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f47ce75e1aa4cda6077f5618c6b2eb2a94e489"
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
#line 2 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/group")]
    public partial class ListGroup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display:inline-block;width:100%");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "display:block;float:left;width:30%");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>ListGroup</h3>\r\n");
#nullable restore
#line 7 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
         if (groups == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<BlazorChat.Component.LoadingIndicator>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 10 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenComponent<MudBlazor.MudPaper>(11);
            __builder.AddAttribute(12, "Width", "300px");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudList>(15);
                __builder2.AddAttribute(16, "Clickable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n");
#nullable restore
#line 16 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                     foreach (var item in groups)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(19, "                        ");
                    __builder3.OpenComponent<MudBlazor.MudListItem>(20);
                    __builder3.AddAttribute(21, "Avatar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                              Icons.Material.Filled.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                                    () => GetListAccInGroup(item.GroupId)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\r\n                            ");
                        __builder4.AddContent(25, 
#nullable restore
#line 19 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                             item.GroupName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(26, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n");
#nullable restore
#line 21 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(28, "                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddMarkupContent(31, "            \r\n            ");
            __builder.OpenComponent<MudBlazor.MudPaper>(32);
            __builder.AddAttribute(33, "Width", "300px");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudList>(36);
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n");
#nullable restore
#line 28 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                     if (accounts == null)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(39, "                        ");
                    __builder3.OpenComponent<MudBlazor.MudListItem>(40);
                    __builder3.AddAttribute(41, "Avatar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                              Icons.Material.Filled.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(43, "\r\n                            Choose a group to see members\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n");
#nullable restore
#line 33 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                    }
                    else
                    {
                        foreach (var item in accounts)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(45, "                            ");
                    __builder3.OpenComponent<MudBlazor.MudListItem>(46);
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(48, "\r\n");
#nullable restore
#line 39 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                 if (item.Status == "Online")
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(49, "                                    ");
                        __builder4.OpenComponent<MudBlazor.MudBadge>(50);
                        __builder4.AddAttribute(51, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                     Color.Success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, "\r\n                                        ");
                            __builder5.OpenComponent<MudBlazor.MudAvatar>(56);
                            __builder5.AddAttribute(57, "Image", "https://www.pngall.com/wp-content/uploads/12/Avatar-Profile-Vector-PNG-Clipart.png");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(58, "\r\n                                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n");
#nullable restore
#line 44 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(60, "                                    ");
                        __builder4.OpenComponent<MudBlazor.MudBadge>(61);
                        __builder4.AddAttribute(62, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 48 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                     Color.Dark

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(66, "\r\n                                        ");
                            __builder5.OpenComponent<MudBlazor.MudAvatar>(67);
                            __builder5.AddAttribute(68, "Image", "https://media.istockphoto.com/vectors/user-icon-flat-isolated-on-white-background-user-symbol-vector-vector-id1300845620?k=20&m=1300845620&s=612x612&w=0&h=f4XTZDAv7NPuZbG0habSpU0sNgECM0X7nbKzTUta3n8=");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n");
#nullable restore
#line 51 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(71, "                                ");
                        __builder4.AddContent(72, 
#nullable restore
#line 52 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(73, "\r\n                            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n");
#nullable restore
#line 54 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(75, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenComponent<MudBlazor.MudButton>(78);
            __builder.AddAttribute(79, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                              Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                         Icons.Material.Filled.AddModerator

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
                                                                                                       AddGroup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(83, "Add");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(85);
            __builder.AddAttribute(86, "class", "nav-link");
            __builder.AddAttribute(87, "href", "dialog");
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(89, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 63 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ListGroup.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "style", "display:block; float:right;width:70%");
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenComponent<BlazorChat.Pages.ChatRoom>(96);
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591