#pragma checksum "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864b516142269793c9d73f4bc5daefe44b6a696a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorChat.Component
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/dialog")]
    public partial class DialogAddGroup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(5, "Add Group");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            ));
            __builder.AddAttribute(7, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __Blazor.BlazorChat.Component.DialogAddGroup.TypeInference.CreateMudTextField_0(__builder2, 9, 10, "Group name ", 11, 
#nullable restore
#line 8 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                    grp_name

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => grp_name = __value, grp_name)));
                __builder2.AddMarkupContent(13, "\r\n        ");
                __Blazor.BlazorChat.Component.DialogAddGroup.TypeInference.CreateMudTextField_1(__builder2, 14, 15, "Group type ", 16, 
#nullable restore
#line 9 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                    grp_type

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => grp_type = __value, grp_type)));
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudPaper>(19);
                __builder2.AddAttribute(20, "Width", "300px");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudList>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(25, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudListItem>(26);
                        __builder4.AddAttribute(27, "Avatar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                      Icons.Material.Filled.Image

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, "\r\n                    Choose members for new group\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n");
#nullable restore
#line 15 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                 if (accounts == null)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(31, "                    ");
                        __builder4.OpenComponent<BlazorChat.Component.LoadingIndicator>(32);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n");
#nullable restore
#line 18 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(34, "                    ");
                        __builder4.OpenComponent<MudBlazor.MudSelect<int>>(35);
                        __builder4.AddAttribute(36, "Label", "Choose Members");
                        __builder4.AddAttribute(37, "MultiSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "SelectedValues", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.HashSet<int>>(
#nullable restore
#line 21 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                                                          lst_acc

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "SelectedValuesChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.HashSet<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.HashSet<int>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => lst_acc = __value, lst_acc))));
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(41, "\r\n");
#nullable restore
#line 22 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                         foreach (var item in accounts)
                        {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(42, "                            ");
                            __builder5.OpenComponent<MudBlazor.MudSelectItem<int>>(43);
                            __builder5.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 24 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                           item.AccountID

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(46, "\r\n");
#nullable restore
#line 25 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                 if (item.Status == "Online")
                                {

#line default
#line hidden
#nullable disable
                                __builder6.AddContent(47, "                                    ");
                                __builder6.OpenComponent<MudBlazor.MudBadge>(48);
                                __builder6.AddAttribute(49, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 27 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                     Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(50, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(51, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(53, "\r\n                                        ");
                                    __builder7.OpenComponent<MudBlazor.MudAvatar>(54);
                                    __builder7.AddAttribute(55, "Image", "https://www.pngall.com/wp-content/uploads/12/Avatar-Profile-Vector-PNG-Clipart.png");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(56, "\r\n                                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(57, "\r\n");
#nullable restore
#line 30 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                                __builder6.AddContent(58, "                                    ");
                                __builder6.OpenComponent<MudBlazor.MudBadge>(59);
                                __builder6.AddAttribute(60, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                     Color.Dark

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(61, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                          true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(62, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(64, "\r\n                                        ");
                                    __builder7.OpenComponent<MudBlazor.MudAvatar>(65);
                                    __builder7.AddAttribute(66, "Image", "https://media.istockphoto.com/vectors/user-icon-flat-isolated-on-white-background-user-symbol-vector-vector-id1300845620?k=20&m=1300845620&s=612x612&w=0&h=f4XTZDAv7NPuZbG0habSpU0sNgECM0X7nbKzTUta3n8=");
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(67, "\r\n                                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(68, "\r\n");
#nullable restore
#line 37 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                }

#line default
#line hidden
#nullable disable
                                __builder6.AddContent(69, "                                ");
                                __builder6.AddContent(70, 
#nullable restore
#line 38 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddMarkupContent(71, "\r\n                            ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(72, "\r\n");
#nullable restore
#line 40 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                        }

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(73, "                    ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(74, "\r\n");
#nullable restore
#line 42 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(75, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n    ");
            }
            ));
            __builder.AddAttribute(78, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(80);
                __builder2.AddAttribute(81, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(85);
                __builder2.AddAttribute(86, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 49 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                          Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Component\DialogAddGroup.razor"
                                                Add

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, "Add");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.BlazorChat.Component.DialogAddGroup
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
