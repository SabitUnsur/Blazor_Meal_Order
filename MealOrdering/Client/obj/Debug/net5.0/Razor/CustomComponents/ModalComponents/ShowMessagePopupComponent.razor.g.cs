#pragma checksum "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7ad9b1d9afaca475adb59742cfd6f0a897fe44"
// <auto-generated/>
#pragma warning disable 1591
namespace MealOrdering.Client.CustomComponents.ModalComponents
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
    public partial class ShowMessagePopupComponent : BaseModalComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-body");
            __builder.OpenElement(2, "p");
#nullable restore
#line 4 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
__builder.AddContent(3, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row justify-content-center");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "ml-auto p-2");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-light");
            __builder.AddAttribute(13, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
                                                         ConfirmClicked

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
__builder.AddContent(14, OkText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\ModalComponents\ShowMessagePopupComponent.razor"
       
    public async override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<String>("Message");
        OkText = "OK";

        await base.SetParametersAsync(parameters);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
