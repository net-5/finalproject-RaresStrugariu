#pragma checksum "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75290e6f380f7806c43f07380da5feb2832bf76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workshops_Details), @"mvc.1.0.view", @"/Views/Workshops/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workshops/Details.cshtml", typeof(AspNetCore.Views_Workshops_Details))]
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
#line 1 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75290e6f380f7806c43f07380da5feb2832bf76d", @"/Views/Workshops/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34aa1a3216b4b47f1974891651b764a2f016fa91", @"/Views/_ViewImports.cshtml")]
    public class Views_Workshops_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Domain.Entities.Workshops>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Workshops</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(270, 40, false);
#line 15 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(310, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(374, 36, false);
#line 18 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(410, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(473, 47, false);
#line 21 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(520, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 43, false);
#line 24 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(627, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(690, 49, false);
#line 27 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(739, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(803, 45, false);
#line 30 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prerequisites));

#line default
#line hidden
            EndContext();
            BeginContext(848, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(911, 48, false);
#line 33 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(959, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1023, 44, false);
#line 36 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Requirements));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1130, 51, false);
#line 39 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1245, 47, false);
#line 42 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlacesAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1355, 43, false);
#line 45 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1462, 39, false);
#line 48 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1564, 52, false);
#line 51 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1680, 48, false);
#line 54 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegistrationLink));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1791, 43, false);
#line 57 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Speaker));

#line default
#line hidden
            EndContext();
            BeginContext(1834, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1898, 51, false);
#line 60 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Speaker.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1996, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75290e6f380f7806c43f07380da5feb2832bf76d11231", async() => {
                BeginContext(2042, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Rares\Desktop\Conferene\Conference\Conference\Views\Workshops\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(2050, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2058, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75290e6f380f7806c43f07380da5feb2832bf76d13559", async() => {
                BeginContext(2080, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2096, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Domain.Entities.Workshops> Html { get; private set; }
    }
}
#pragma warning restore 1591
