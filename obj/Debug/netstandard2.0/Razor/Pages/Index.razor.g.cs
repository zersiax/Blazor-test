#pragma checksum "D:\projecten\BlazorDemo\Blazor-test\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1263182b655a2f6cfafbc021a8a9bf970c0ef315"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#line 7 "D:\projecten\BlazorDemo\Blazor-test\_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorDemo.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
