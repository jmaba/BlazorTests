#pragma checksum "C:\Users\AdiB\Desktop\Blazor Samples\BlazorHostedOnServer\BlazorHostedOnServer.App\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6492b5d9a66cac5c8d46cdc7dd8296c313b5da64"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHostedOnServer.App.Pages
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
    using BlazorHostedOnServer.App;
    using BlazorHostedOnServer.App.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            builder.OpenComponent<BlazorHostedOnServer.App.Shared.SurveyPrompt>(1);
            builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591