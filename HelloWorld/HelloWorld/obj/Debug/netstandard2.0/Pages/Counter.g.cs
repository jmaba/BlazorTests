#pragma checksum "C:\Users\AdiB\Desktop\Blazor Samples\HelloWorld\HelloWorld\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad09c1a9a98bd6b891221e2b9bb57aa8a0a04035"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using HelloWorld;
    using HelloWorld.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, currentCount);
            builder.CloseElement();
            builder.AddContent(4, "\n\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(IncrementCount));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
            builder.AddMarkupContent(9, "\n<br>\n\n\n");
            builder.OpenElement(10, "input");
            builder.AddAttribute(11, "type", "text");
            builder.AddAttribute(12, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(Name));
            builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => Name = __value, Name));
            builder.CloseElement();
            builder.AddMarkupContent(14, "\n\n<br>");
        }
        #pragma warning restore 1998
#line 15 "C:\Users\AdiB\Desktop\Blazor Samples\HelloWorld\HelloWorld\Pages\Counter.cshtml"
            

    private string Name { get; set; } = "Sss";

    private string Message { get; set; }

    int currentCount = 0;

    private void IncrementCount()
    {
        currentCount += 1;
        Name = "223";
        StateHasChanged();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591