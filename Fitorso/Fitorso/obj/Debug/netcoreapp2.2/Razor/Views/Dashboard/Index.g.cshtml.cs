#pragma checksum "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac1c23234fc5e6cc99878707835120928de8829b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\_ViewImports.cshtml"
using Fitorso;

#line default
#line hidden
#line 2 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\_ViewImports.cshtml"
using Fitorso.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac1c23234fc5e6cc99878707835120928de8829b", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c699b42fbeb3b18d24275fac5dd0055b0526c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitorso.Viewmodels.DashboardViewmodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(77, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(106, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1c23234fc5e6cc99878707835120928de8829b4596", async() => {
                BeginContext(112, 32, true);
                WriteLiteral("\r\n    <title>title</title>\r\n    ");
                EndContext();
                BeginContext(144, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac1c23234fc5e6cc99878707835120928de8829b5010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(207, 1098, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1c23234fc5e6cc99878707835120928de8829b7139", async() => {
                BeginContext(213, 43, true);
                WriteLiteral("\r\n    <div>\r\n        <ul>\r\n            <li>");
                EndContext();
                BeginContext(257, 48, false);
#line 18 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Html.ActionLink("Account", "Profile", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(305, 23, true);
                WriteLiteral("</li>\r\n            <li>");
                EndContext();
                BeginContext(329, 48, false);
#line 19 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Html.ActionLink("Training", "Index", "Exercise"));

#line default
#line hidden
                EndContext();
                BeginContext(377, 136, true);
                WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"boxes\">\r\n        <div class=\"Box Box1\">\r\n            <h3>Weight</h3>\r\n            <h4>");
                EndContext();
                BeginContext(514, 65, false);
#line 25 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Html.ActionLink(Model.Weight.ToString(), "WeightValues", "Value"));

#line default
#line hidden
                EndContext();
                BeginContext(579, 19, true);
                WriteLiteral("</h4>\r\n            ");
                EndContext();
                BeginContext(599, 42, false);
#line 26 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
       Write(Html.ActionLink("+", "AddWeight", "Value"));

#line default
#line hidden
                EndContext();
                BeginContext(641, 93, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"Box Box2\">\r\n            <h3>Fat%</h3>\r\n            <h4>");
                EndContext();
                BeginContext(735, 70, false);
#line 30 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Html.ActionLink(@Model.FatPercentage.ToString(), "FatValues", "Value"));

#line default
#line hidden
                EndContext();
                BeginContext(805, 19, true);
                WriteLiteral("</h4>\r\n            ");
                EndContext();
                BeginContext(825, 49, false);
#line 31 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
       Write(Html.ActionLink("+", "AddFatpercentage", "value"));

#line default
#line hidden
                EndContext();
                BeginContext(874, 92, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"Box Box3\">\r\n            <h3>BMI</h3>\r\n            <h4>");
                EndContext();
                BeginContext(967, 60, false);
#line 35 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Html.ActionLink(@Model.Bmi.ToString(), "BmiValues", "Value"));

#line default
#line hidden
                EndContext();
                BeginContext(1027, 19, true);
                WriteLiteral("</h4>\r\n            ");
                EndContext();
                BeginContext(1047, 40, false);
#line 36 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
       Write(Html.ActionLink("+", "CalcBmi", "value"));

#line default
#line hidden
                EndContext();
                BeginContext(1087, 94, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"Box Box4\">\r\n            <h3>Quote</h3>\r\n            <h2>");
                EndContext();
                BeginContext(1182, 11, false);
#line 40 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
           Write(Model.Quote);

#line default
#line hidden
                EndContext();
                BeginContext(1193, 43, true);
                WriteLiteral("</h2>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(1237, 59, false);
#line 45 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Dashboard\Index.cshtml"
Write(Html.ActionLink("GO TO TRAINING PAGE", "index", "Exercise"));

#line default
#line hidden
                EndContext();
                BeginContext(1296, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1305, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitorso.Viewmodels.DashboardViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
