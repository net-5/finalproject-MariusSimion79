#pragma checksum "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d09c7afc131bafcdc449a467db7027334ca96ce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sponsors_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Sponsors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sponsors/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sponsors_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09c7afc131bafcdc449a467db7027334ca96ce7", @"/Areas/Admin/Views/Sponsors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6ccf5b6fd3bb1a16872d36e9fc664cd8c62a07", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sponsors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Domain.Entities.Sponsors>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Sponsors</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(266, 38, false);
#line 15 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(304, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(366, 34, false);
#line 18 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(400, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(461, 40, false);
#line 21 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(501, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(563, 36, false);
#line 24 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(599, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(660, 43, false);
#line 27 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(703, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(765, 39, false);
#line 30 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(804, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(865, 44, false);
#line 33 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(909, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(971, 40, false);
#line 36 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1072, 47, false);
#line 39 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1181, 43, false);
#line 42 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1285, 44, false);
#line 45 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1391, 40, false);
#line 48 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1492, 49, false);
#line 51 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SponsorTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1603, 45, false);
#line 54 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SponsorTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1709, 42, false);
#line 57 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1813, 38, false);
#line 60 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1912, 43, false);
#line 63 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2017, 39, false);
#line 66 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2104, 54, false);
#line 71 "d:\IT\SIIC Seria5 .net\GIT UPLOAD\finalproject-MariusSimion79\Conference\Areas\Admin\Views\Sponsors\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2166, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d09c7afc131bafcdc449a467db7027334ca96ce712809", async() => {
                BeginContext(2188, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2204, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Domain.Entities.Sponsors> Html { get; private set; }
    }
}
#pragma warning restore 1591
