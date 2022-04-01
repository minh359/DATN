#pragma checksum "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "683a7d2faa268409ddea927205f49d9e2eeced43"
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
#line 11 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatroom")]
    public partial class ChatRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
 if (!_isChatting)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>\r\n        Enter your name to start chatting:\r\n    </p>\r\n");
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "maxlength", "32");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                              _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                     Chat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "<span class=\"oi oi-chat\" aria-hidden=\"true\"></span> Chat!");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"

    // Error messages
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
     if (_message != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "invalid-feedback");
            __builder.AddContent(17, 
#nullable restore
#line 19 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                       _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "small");
            __builder.AddAttribute(20, "id", "emailHelp");
            __builder.AddAttribute(21, "class", "form-text text-muted");
            __builder.AddContent(22, 
#nullable restore
#line 20 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                            _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 21 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
     
}
else
{
    // banner to show current user

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(27, "role", "alert");
            __builder.AddMarkupContent(28, "\r\n        <span class=\"oi oi-person mr-2\" aria-hidden=\"true\"></span>\r\n        ");
            __builder.OpenElement(29, "span");
            __builder.AddContent(30, "You are connected as ");
            __builder.OpenElement(31, "b");
            __builder.AddContent(32, 
#nullable restore
#line 28 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                       _username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-sm btn-warning ml-md-auto");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                     DisconnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Disconnect");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 31 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
    // display messages

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "id", "scrollbox");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 33 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
     foreach (var item in _messages)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
         if (item.IsNotice)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "alert alert-info");
            __builder.AddContent(46, 
#nullable restore
#line 37 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                           item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 38 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", 
#nullable restore
#line 41 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                         item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "user");
            __builder.AddContent(54, 
#nullable restore
#line 42 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                   item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "msg");
            __builder.AddContent(58, 
#nullable restore
#line 43 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                  item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 45 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "    <hr>\r\n\r\n\r\n    ");
            __Blazor.BlazorChat.Pages.ChatRoom.TypeInference.CreateMudTextField_0(__builder, 62, 63, "Name", 64, 
#nullable restore
#line 50 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            , 65, 
#nullable restore
#line 50 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                _newMessage

#line default
#line hidden
#nullable disable
            , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _newMessage = __value, _newMessage)));
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudButton>(68);
            __builder.AddAttribute(69, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 51 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "EndIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                  Icons.Material.Filled.Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 51 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                                                                () => SendAsync(_newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(74, "Send");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(76);
            __builder.AddAttribute(77, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                          Icons.Material.Filled.FavoriteBorder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 52 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                       Color.Inherit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 52 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                                                                                            Edge.End

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(81);
            __builder.AddAttribute(82, "HtmlTag", "label");
            __builder.AddAttribute(83, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 54 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                   Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                   Icons.Filled.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "for", "fileInput");
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, " \r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(87);
            __builder.AddAttribute(88, "HtmlTag", "label");
            __builder.AddAttribute(89, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                   Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                   Icons.Filled.AttachFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "for", "fileInput");
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\r\n\r\n    ");
            __builder.OpenComponent<MudBlazor.MudIconButton>(93);
            __builder.AddAttribute(94, "HtmlTag", "label");
            __builder.AddAttribute(95, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 64 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                          Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
                          Icons.Filled.PhotoCamera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "for", "fileInput");
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 72 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "G:\Subject\Công nghệ phần mềm\ĐATN\Code\BlazorChat\Pages\ChatRoom.razor"
       
    // flag to indicate chat status
    private bool _isChatting = false;

    // name of the user who will be chatting
    private string _username;

    // on-screen message
    private string _message;

    // new message input
    private string _newMessage;

    // list of messages in chat
    private List<Message> _messages = new List<Message>();

    private string _hubUrl;
    private HubConnection _hubConnection;

    public async Task Chat()
    {
        // check username is valid
        if (string.IsNullOrWhiteSpace(_username))
        {
            _message = "Please enter a name";
            return;
        };

        try
        {
            // Start chatting and force refresh UI.
            _isChatting = true;
            await Task.Delay(1);

            // remove old messages if any
            _messages.Clear();

            // Create the chat client
            string baseUrl = navigationManager.BaseUri;

            _hubUrl = baseUrl.TrimEnd('/') + "/chathub";

            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_hubUrl)
                .Build();

            _hubConnection.On<string, string>("Broadcast", BroadcastMessage);

            await _hubConnection.StartAsync();

            await SendAsync($"[Notice] {_username} joined chat room.");
        }
        catch (Exception e)
        {
            _message = $"ERROR: Failed to start chat client: {e.Message}";
            _isChatting = false;
        }
    }

    private void BroadcastMessage(string name, string message)
    {
        bool isMine = name.Equals(_username, StringComparison.OrdinalIgnoreCase);

        _messages.Add(new Message(name, message, isMine));

        // Inform blazor the UI needs updating
        StateHasChanged();
    }

    private async Task DisconnectAsync()
    {
        if (_isChatting)
        {
            await SendAsync($"[Notice] {_username} left chat room.");

            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();

            _hubConnection = null;
            _isChatting = false;
        }
    }

    private async Task SendAsync(string message)
    {
        if (_isChatting && !string.IsNullOrWhiteSpace(message))
        {
            await _hubConnection.SendAsync("Broadcast", _username, message);

            _newMessage = string.Empty;
        }
    }

    private class Message
    {
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public string Username { get; set; }
        public string Body { get; set; }
        public bool Mine { get; set; }

        public bool IsNotice => Body.StartsWith("[Notice]");
        
        //cho nay se kiem tra xem accountId cua message co = accountID dang dang nhap ko
        public string CSS => Mine ? "sent" : "received";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.BlazorChat.Pages.ChatRoom
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
