#pragma checksum "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f930e46e903529c802876432a9da6ef400282f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sponsors_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sponsors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sponsors/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sponsors_Index))]
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
#line 1 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f930e46e903529c802876432a9da6ef400282f", @"/Areas/Admin/Views/Sponsors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6ccf5b6fd3bb1a16872d36e9fc664cd8c62a07", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sponsors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Sponsors>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(176, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f930e46e903529c802876432a9da6ef400282f4091", async() => {
                BeginContext(199, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(306, 38, false);
#line 17 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 40, false);
#line 20 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(440, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(496, 43, false);
#line 23 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(539, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(595, 44, false);
#line 26 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(639, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(695, 47, false);
#line 29 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(742, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(798, 44, false);
#line 32 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(842, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(898, 49, false);
#line 35 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SponsorTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(947, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1003, 42, false);
#line 38 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1101, 43, false);
#line 41 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1279, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1340, 37, false);
#line 51 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1445, 39, false);
#line 54 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1552, 42, false);
#line 57 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1662, 43, false);
#line 60 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1773, 46, false);
#line 63 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1887, 43, false);
#line 66 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1998, 48, false);
#line 69 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SponsorTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2114, 41, false);
#line 72 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Active));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2223, 42, false);
#line 75 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2333, 53, false);
#line 78 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2411, 59, false);
#line 79 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2470, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2495, 57, false);
#line 80 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2607, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Sponsors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
