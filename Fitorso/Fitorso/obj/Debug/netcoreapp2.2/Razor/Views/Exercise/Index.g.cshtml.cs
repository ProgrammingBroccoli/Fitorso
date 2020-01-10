#pragma checksum "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f569f58dac5f1f86c72c2237247f0cdb614dc9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercise_Index), @"mvc.1.0.view", @"/Views/Exercise/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exercise/Index.cshtml", typeof(AspNetCore.Views_Exercise_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f569f58dac5f1f86c72c2237247f0cdb614dc9c5", @"/Views/Exercise/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c699b42fbeb3b18d24275fac5dd0055b0526c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Exercise_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitorso.Viewmodels.ExerciseViewmodel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 195, true);
            WriteLiteral("<table class=\"table table-striped table-hover \", id=\"table\">\r\n    <tr>\r\n        <th>Exercise</th>\r\n        <th>Musclegroup</th>\r\n        <th>Description</th>\r\n        <th>Remove</th>\r\n    </tr>\r\n");
            EndContext();
#line 9 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
     foreach (var item in @Model.FavoriteExercises)
    {

#line default
#line hidden
            BeginContext(300, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(349, 9, false);
#line 13 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(358, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(414, 72, false);
#line 16 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
           Write(Model.Musclegroups.SingleOrDefault(e => e.Id == item.MusclegroupId).Name);

#line default
#line hidden
            EndContext();
            BeginContext(486, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(542, 16, false);
#line 19 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(614, 141, false);
#line 22 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
           Write(Html.ActionLink("Remove",
                    "",
                    null, new{ onclick = "Delete(" +item.Id + "," +Model.User.Id + ");"}));

#line default
#line hidden
            EndContext();
            BeginContext(755, 54, true);
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(816, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(827, 67, false);
#line 30 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
Write(Html.ActionLink("Add new exercise", "AddExerciseIndex", "Exercise"));

#line default
#line hidden
            EndContext();
            BeginContext(894, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(897, 73, false);
#line 31 "C:\Users\Ruben\Desktop\Fitorso\Fitorso\Fitorso\Views\Exercise\Index.cshtml"
Write(Html.ActionLink("Generate training", "GenerateTrainingIndex", "Exercise"));

#line default
#line hidden
            EndContext();
            BeginContext(970, 408, true);
            WriteLiteral(@"
<script>
    function Delete(exerciseId, userId) {
        alert('function called');
        $.ajax({
            type: ""Post"",
            url: '/Exercise/RemoveFavorite',
            data: {
                'exerciseId': exerciseId,
                'userId': userId
            }
        });
        document.getElementById(""table"").deleteRow(1);
        alert('succeed');
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitorso.Viewmodels.ExerciseViewmodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
