// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class TestComponent<TItem1, TItem2> : Microsoft.AspNetCore.Components.ComponentBase
    where TItem1 : class
    where TItem2 : struct
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TItem1 = null!;

#line default
#line hidden
#nullable disable
        }
        ))();
        ((System.Action)(() => {
#pragma warning disable CS0693
#pragma warning disable CS8321
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
void __TypeConstraints_TItem1<TItem1>() where TItem1 : class
{
}
#pragma warning restore CS0693
#pragma warning restore CS8321

#line default
#line hidden
#nullable disable
        }
        ))();
        ((System.Action)(() => {
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TItem2 = null!;

#line default
#line hidden
#nullable disable
        }
        ))();
        ((System.Action)(() => {
#pragma warning disable CS0693
#pragma warning disable CS8321
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
void __TypeConstraints_TItem2<TItem2>() where TItem2 : struct
{
}
#pragma warning restore CS0693
#pragma warning restore CS8321

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
 foreach (var item2 in Items2)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = ChildContent(item2);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "x:\dir\subdir\Test\TestComponent.cshtml"
        
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter] public TItem1 Item1 { get; set; }
    [Parameter] public List<TItem2> Items2 { get; set; }
    [Parameter] public RenderFragment<TItem2> ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
