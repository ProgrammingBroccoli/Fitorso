#pragma checksum "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11d96228b5c93f12a929591bc8734d39017f59b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Value_FatValues), @"mvc.1.0.view", @"/Views/Value/FatValues.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Value/FatValues.cshtml", typeof(AspNetCore.Views_Value_FatValues))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11d96228b5c93f12a929591bc8734d39017f59b", @"/Views/Value/FatValues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c699b42fbeb3b18d24275fac5dd0055b0526c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Value_FatValues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitorso.Viewmodels.ValueViewmodel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(50, 891, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e11d96228b5c93f12a929591bc8734d39017f59b3355", async() => {
                BeginContext(56, 402, true);
                WriteLiteral(@"
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);


    function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Date', 'Weight'],
            [new Date(2019, 10, 11), ");
                EndContext();
                BeginContext(459, 21, false);
#line 13 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
                                Write(Model.Values[0].Value);

#line default
#line hidden
                EndContext();
                BeginContext(480, 41, true);
                WriteLiteral("],\r\n            [new Date(2019, 10, 12), ");
                EndContext();
                BeginContext(522, 21, false);
#line 14 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
                                Write(Model.Values[1].Value);

#line default
#line hidden
                EndContext();
                BeginContext(543, 41, true);
                WriteLiteral("],\r\n            [new Date(2019, 10, 13), ");
                EndContext();
                BeginContext(585, 21, false);
#line 15 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
                                Write(Model.Values[2].Value);

#line default
#line hidden
                EndContext();
                BeginContext(606, 328, true);
                WriteLiteral(@"]
        ]);

        var options = {
            title: 'fat percentage',
            curveType: 'function',
            legend: { position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
    }
</script>
");
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
            BeginContext(941, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(943, 427, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e11d96228b5c93f12a929591bc8734d39017f59b6474", async() => {
                BeginContext(949, 188, true);
                WriteLiteral("\r\n<div id=\"curve_chart\" style=\"width: 900px; height: 500px\"></div>\r\n<table class=\"table table-striped table-hover \">\r\n\r\n    <tr>\r\n        <th>Value</th>\r\n        <th>Date</th>\r\n    </tr>\r\n");
                EndContext();
#line 38 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
     foreach (var item in @Model.Values)
    {

#line default
#line hidden
                BeginContext(1186, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1235, 10, false);
#line 42 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
           Write(item.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1245, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1301, 9, false);
#line 45 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
           Write(item.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1310, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 48 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Value\FatValues.cshtml"
    }

#line default
#line hidden
                BeginContext(1353, 10, true);
                WriteLiteral("</table>\r\n");
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
            BeginContext(1370, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitorso.Viewmodels.ValueViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591