#pragma checksum "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7647cbb68c6eab3f63d5161b476f59d0e5c0f659"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Hi, ");
                __builder2.AddContent(4, 
#nullable restore
#line 5 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Pages\Index.razor"
                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(5, ". Welcome Back!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        Let\'s admire ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
                __builder2.AddAttribute(8, "href", "army");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "your army");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(11, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "<h1> Welcome to Blazor Battles!</h1>\r\n        ");
                __builder2.OpenComponent<BlazorBattles.Client.Pages.Login>(13);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
