#pragma checksum "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c516bf6d2b176a3984a4dbe8a591066b8cabf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\_ViewImports.cshtml"
using FurnitureHouse;

#line default
#line hidden
#line 2 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\_ViewImports.cshtml"
using FurnitureHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c516bf6d2b176a3984a4dbe8a591066b8cabf0", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be11d2bbd9ecd7e48f1ef258e8234eb2fa7c7d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FurnitureHouse.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 144, true);
            WriteLiteral("\r\n<br /><br />\r\n\r\n<div class=\"row\">\r\n\t<div class=\"col-6\">\r\n\t\t<h2 class=\"text-info\"> Food List</h2>\r\n\t</div>\r\n\t<div class=\"col-6 text-right\">\r\n\t\t");
            EndContext();
            BeginContext(234, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4888d27be948929914a2ed70bae938", async() => {
                BeginContext(278, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Product ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 121, true);
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n\t<table class=\"table table-striped border\">\r\n\t\t<tr class=\"table-info\">\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(450, 32, false);
#line 22 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(482, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(508, 33, false);
#line 25 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(541, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(567, 37, false);
#line 28 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Available));

#line default
#line hidden
            EndContext();
            BeginContext(604, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(630, 40, false);
#line 31 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.ProductTypes));

#line default
#line hidden
            EndContext();
            BeginContext(670, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(696, 39, false);
#line 34 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.SpecialTags));

#line default
#line hidden
            EndContext();
            BeginContext(735, 51, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\r\n");
            EndContext();
#line 40 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
         foreach(var item in Model){

#line default
#line hidden
            BeginContext(818, 21, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(840, 31, false);
#line 43 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(871, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(897, 32, false);
#line 46 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(929, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(955, 36, false);
#line 49 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(m => item.Available));

#line default
#line hidden
            EndContext();
            BeginContext(991, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1017, 44, false);
#line 52 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(m => item.ProductTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1087, 43, false);
#line 55 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(m => item.SpecialTags.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1155, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3075f99b94284e98a4abce0131b39727", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 58 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1209, 21, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n");
            EndContext();
#line 61 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Admin\Views\Products\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(1235, 17, true);
            WriteLiteral("\t</table>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FurnitureHouse.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
