#pragma checksum "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3bc7988d3fa2eb0a07094a5602b647b5827813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_), @"mvc.1.0.view", @"/Views/Account/.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/.cshtml", typeof(AspNetCore.Views_Account_))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3bc7988d3fa2eb0a07094a5602b647b5827813", @"/Views/Account/.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c699b42fbeb3b18d24275fac5dd0055b0526c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitorso.Viewmodels.AccountViewmodel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(170, 23, false);
#line 5 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(195, 48, true);
            WriteLiteral("    <h4>Create a new account.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(248, 58, false);
#line 8 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(308, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(347, 75, false);
#line 10 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
   Write(Html.LabelFor(m => m.User.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(422, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(470, 67, false);
#line 12 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
       Write(Html.TextBoxFor(m => m.User.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(537, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(606, 78, false);
#line 16 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
   Write(Html.LabelFor(m => m.User.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(684, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(732, 71, false);
#line 18 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
       Write(Html.PasswordFor(m => m.User.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(803, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(872, 85, false);
#line 22 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
   Write(Html.LabelFor(m => m.User.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(957, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1005, 78, false);
#line 24 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
       Write(Html.PasswordFor(m => m.User.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 215, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Register\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Account\.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitorso.Viewmodels.AccountViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591