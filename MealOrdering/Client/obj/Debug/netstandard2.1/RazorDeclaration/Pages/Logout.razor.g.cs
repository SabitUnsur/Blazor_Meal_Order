// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MealOrdering.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Client.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.ResponseModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using MealOrdering.Shared.CustomExceptions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\Pages\Logout.razor"
       

    [Inject]
    ILocalStorageService localStorageService { get; set; }

    [Inject]
    AuthenticationStateProvider AuthenticationStateProvider { get; set; }

    [Inject]
    HttpClient Client { get; set; }


    [Inject]
    NavigationManager NavManeger { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await localStorageService.RemoveItemAsync("token");
        await localStorageService.RemoveItemAsync("email");
        await localStorageService.RemoveItemAsync("UserId");
        
        (AuthenticationStateProvider as AuthStateProvider).NotifyUserLogout();

        Client.DefaultRequestHeaders.Authorization = null;

        NavManeger.NavigateTo("/login");
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
