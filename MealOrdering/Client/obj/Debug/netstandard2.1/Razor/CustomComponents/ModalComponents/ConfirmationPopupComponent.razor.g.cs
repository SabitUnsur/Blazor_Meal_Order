#pragma checksum "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9121de5b3095ca2a7957a447b4ef4abbdf116f"
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
    public partial class ConfirmationPopupComponent : BaseModalComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-body");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "p");
#nullable restore
#line 6 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
__builder.AddContent(4, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row justify-content-center");
            __builder.AddMarkupContent(9, "\n\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-flex");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-danger");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
                                                  ConfirmClicked

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 12 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
__builder.AddContent(16, YesText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-light");
            __builder.AddAttribute(20, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
                                                 CancelClicked

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 13 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
__builder.AddContent(21, CancelText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\sabit\OneDrive\Masaüstü\MealOrdering-master\MealOrdering-master\MealOrdering\Client\CustomComponents\ModalComponents\ConfirmationPopupComponent.razor"
       

    public async override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<String>("Message") ?? "No message found";
        YesText = parameters.GetValueOrDefault<String>("YesText") ?? "Yes";
        CancelText = parameters.GetValueOrDefault<String>("CancelText") ?? "Cancel";

        await base.SetParametersAsync(parameters);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
