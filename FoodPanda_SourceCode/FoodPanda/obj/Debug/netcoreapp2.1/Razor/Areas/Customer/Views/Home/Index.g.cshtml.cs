#pragma checksum "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cf30834fe06d804072c93c4a91387f5ec5aadf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
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
#line 1 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\_ViewImports.cshtml"
using FurnitureHouse;

#line default
#line hidden
#line 2 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\_ViewImports.cshtml"
using FurnitureHouse.Models;

#line default
#line hidden
#line 2 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
using FurnitureHouse.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cf30834fe06d804072c93c4a91387f5ec5aadf", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa43f30ba4dd853bd491cdca5901fcae0093db89", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FurnitureHouse.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(86, 18, true);
            WriteLiteral("\r\n<br /><br />\r\n\r\n");
            EndContext();
            BeginContext(104, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "439c6fa097ab454bb27a0720b38aa8ef", async() => {
                BeginContext(161, 153, true);
                WriteLiteral("\r\n\t<label for=\"search\">Search</label>\r\n\t<input \ttype=\"text\" name=\"search\" id=\"search\" />\r\n\t<button type=\"submit\"><i class=\"fas fa-search\"></i></button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 131, Url.Action("Index", "Home"), 131, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(321, 23, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 13 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
     if (Model.Count() > 0)
	{
		foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(410, 283, true);
            WriteLiteral(@"			<div class=""border border-info rounded col-6"" style=""margin-top:10px;margin-bottom:10px;padding:10px;"">
				<div class=""row"">
					<div class=""col-9"">
						<div class=""row"">
							<div class=""col-9"">
								<label class=""text-primary"" style=""font-size:21px;color:maroon;"">");
            EndContext();
            BeginContext(694, 9, false);
#line 22 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(703, 69, true);
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t\t<br />\r\n\t\t\t\t\t\t\t\t<label class=\"badge badge-primary\">");
            EndContext();
            BeginContext(773, 21, false);
#line 24 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                                              Write(item.SpecialTags.Name);

#line default
#line hidden
            EndContext();
            BeginContext(794, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 25 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                 if (item.Spicyness == "1")
								{

#line default
#line hidden
            BeginContext(852, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<label class=\"badge badge-info\">");
            EndContext();
            BeginContext(894, 21, false);
#line 27 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                                               Write(Products.EScipy.Spicy);

#line default
#line hidden
            EndContext();
            BeginContext(915, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 28 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
								}

#line default
#line hidden
            BeginContext(936, 8, true);
            WriteLiteral("\t\t\t\t\t\t\t\t");
            EndContext();
#line 29 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                 if (item.Spicyness == "2")
								{

#line default
#line hidden
            BeginContext(984, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<label class=\"badge badge-info\">");
            EndContext();
            BeginContext(1026, 25, false);
#line 31 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                                               Write(Products.EScipy.VerySpicy);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 32 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
								}

#line default
#line hidden
            BeginContext(1072, 88, true);
            WriteLiteral("\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-3 text-right\" style=\"color:maroon\">\r\n\t\t\t\t\t\t\t\t<h4>$");
            EndContext();
            BeginContext(1161, 10, false);
#line 35 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 100, true);
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t<div class=\"col-9\">\r\n\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(1272, 16, false);
#line 40 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 70, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<div class=\"col-3\" text-right>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1358, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7954d75ee6f6467d8bef775ca873de40", async() => {
                BeginContext(1430, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1441, 82, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-3\">\r\n\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1523, "\"", 1540, 1);
#line 50 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1529, item.Image, 1529, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1541, 118, true);
            WriteLiteral(" width=\"90%\" height=\"80%\" style=\"border-radius:5px;border:1px solid #bbb9b9;\" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
            EndContext();
#line 54 "C:\Users\mahbub\Desktop\dot net pro\FurnitureHouse\FurnitureHouse\Areas\Customer\Views\Home\Index.cshtml"

		}


	}

#line default
#line hidden
            BeginContext(1674, 8, true);
            WriteLiteral("</div>\r\n");
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
