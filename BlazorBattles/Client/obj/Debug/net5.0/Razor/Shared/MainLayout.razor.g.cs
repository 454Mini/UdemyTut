#pragma checksum "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b553f816fe057979ffae1010356be14e04bddf3d"
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
#nullable restore
#line 2 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page");
            __builder.AddAttribute(4, "b-l1st1jcckf");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "sidebar");
            __builder.AddAttribute(7, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.NavMenu>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-l1st1jcckf");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "top-row px-4");
            __builder.AddAttribute(15, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.TopMenu>(16);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-l1st1jcckf");
            __builder.AddContent(21, 
#nullable restore
#line 17 "C:\Users\henri\OneDrive\GitProjects\Tutorial_Projects_School\BlazorBattles\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
