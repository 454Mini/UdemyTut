#pragma checksum "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0736d23b77d16be6f6c58bcbc6dbd69e08b1f6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Shared
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
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "top-menu");
                __builder2.AddMarkupContent(4, "<img src=\"icons/I_C_Banana.png\">");
                __builder2.OpenElement(5, "span");
                __builder2.AddAttribute(6, "class", "popover-header");
                __builder2.AddContent(7, 
#nullable restore
#line 7 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\TopMenu.razor"
                                                                            BananaService.Bananas

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenComponent<BlazorBattles.Client.Shared.AddBananas>(9);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(12);
                __builder2.AddAttribute(13, "href", "");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
                __builder2.AddAttribute(18, "href", "register");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "Registrer");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\TopMenu.razor"
       
    //Subscribe til OnChanged event af Ibananas
    protected override void OnInitialized()
    {
        BananaService.OnChange += StateHasChanged;
        //Så ved den at den på state skal ændre
        //Component lifecyckle, derfor skal den overrides
    }

    //Unsubscripe when disposed
    public void Dispose()
    {
        BananaService.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorBattles.Client.Services.IBananaService BananaService { get; set; }
    }
}
#pragma warning restore 1591
