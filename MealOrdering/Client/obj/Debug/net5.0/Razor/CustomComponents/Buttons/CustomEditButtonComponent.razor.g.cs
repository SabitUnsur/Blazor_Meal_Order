#pragma checksum "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5815443e8a6c4fcbd246e58c8f2f49c085d6a4"
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
    public partial class CustomEditButtonComponent : BaseButtonComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n\r\n\r\n");
            __builder.OpenComponent<global::MealOrdering.Client.CustomComponents.Buttons.ButtonComponent>(1);
            __builder.AddAttribute(2, "Caption", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 5 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                            Caption ?? "Edit"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                          Color ?? "secondary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 7 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                         Icon ?? "pencil-square-o"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                          OnClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ToolTipStr", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                               ToolTipStr ?? "Edit"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "IsOutline", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 10 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                             IsOutline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "IsSmall", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 11 "C:\Users\sabit\source\repos\MealOrdering\MealOrdering\Client\CustomComponents\Buttons\CustomEditButtonComponent.razor"
                           IsSmall

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
