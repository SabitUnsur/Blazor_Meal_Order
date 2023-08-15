#pragma checksum "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b2277db420c8d25eed0a8ddf3b6dc698321d053"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrdering.Client.CustomComponents.Buttons
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
    public partial class ButtonComponent : BaseButtonComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn" + (
#nullable restore
#line 3 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                    IsSmall ? " btn-sm" :""

#line default
#line hidden
#nullable disable
            ) + " btn" + (
#nullable restore
#line 3 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                                                  IsOutline ? "-outline":""

#line default
#line hidden
#nullable disable
            ) + "-" + (
#nullable restore
#line 3 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                                                                              Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "type", "submit");
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 5 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                   IsBusy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "onclick", 
#nullable restore
#line 6 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                  OnClick

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "title", 
#nullable restore
#line 7 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                ToolTipStr

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "class", "fa" + " fa-" + (
#nullable restore
#line 9 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
                     Icon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "aria-hidden", "true");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
     if (IsBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<span class=\"spinner-border-sm mr-1\"></span>");
#nullable restore
#line 14 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\ButtonComponent.razor"
__builder.AddContent(10, Caption);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
