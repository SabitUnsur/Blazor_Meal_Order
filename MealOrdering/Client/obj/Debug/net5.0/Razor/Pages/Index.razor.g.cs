#pragma checksum "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9f64dd206f4c38ba174594185c583a88f96abe"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrdering.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.ModalComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Pages.PageProcess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.ResponseModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Hello, world! | Counter is ");
#nullable restore
#line 5 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\Pages\Index.razor"
__builder.AddContent(2, counter);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<global::MealOrdering.Client.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\Pages\Index.razor"
      
    private int counter = 0;

    protected async override Task OnInitializedAsync()
    {
       counter = await localStorage.GetItemAsync<int>("counter");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591