#pragma checksum "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "173c2da55877750ee94a87bb308adfeb146397a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Workshops_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Workshops/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Workshops/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Workshops_Index))]
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
#line 1 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173c2da55877750ee94a87bb308adfeb146397a9", @"/Areas/Admin/Views/Workshops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6ccf5b6fd3bb1a16872d36e9fc664cd8c62a07", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4742dbd03414ecfe2819bb5d174ea2f66d189645", @"/Areas/Admin/Views/Workshops/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Workshops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Workshops>>
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(177, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "173c2da55877750ee94a87bb308adfeb146397a94306", async() => {
                BeginContext(200, 10, true);
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
            BeginContext(214, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 38, false);
#line 17 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(345, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(401, 40, false);
#line 20 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(441, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(497, 47, false);
#line 23 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(544, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(600, 49, false);
#line 26 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(649, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(705, 48, false);
#line 29 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(753, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(809, 51, false);
#line 32 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(860, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(916, 43, false);
#line 35 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(959, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1015, 45, false);
#line 38 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1116, 52, false);
#line 41 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1286, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1335, 37, false);
#line 50 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1428, 39, false);
#line 53 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1523, 46, false);
#line 56 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1625, 48, false);
#line 59 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1729, 47, false);
#line 62 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1832, 50, false);
#line 65 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1938, 42, false);
#line 68 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2036, 44, false);
#line 71 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpeakerId));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2136, 51, false);
#line 74 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2243, 50, false);
#line 77 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2293, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2314, 57, false);
#line 78 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2392, 54, false);
#line 79 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 82 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Workshops\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2485, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Workshops>> Html { get; private set; }
    }
}
#pragma warning restore 1591
