#pragma checksum "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f9760ae5ad1950ffcae7fff6fb705cc1e31c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Description), @"mvc.1.0.view", @"/Views/Home/Description.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Description.cshtml", typeof(AspNetCore.Views_Home_Description))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f9760ae5ad1950ffcae7fff6fb705cc1e31c90", @"/Views/Home/Description.cshtml")]
    public class Views_Home_Description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91491a16bf6d40538760610ed04b5f44", async() => {
                BeginContext(64, 431, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Description</title>
    <style>
        table {
            width: 500px; /* Ширина таблицы */
            border: 1px solid green; /* Рамка вокруг таблицы */
            margin: auto; /* Выравниваем таблицу по центру окна  */
        }

        td {
            text-align: center; /* Выравниваем текст по центру ячейки */
        }
    </style>
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
            BeginContext(502, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(504, 789, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad8d24e6612e41c984a7a1cb972a0b3d", async() => {
                BeginContext(510, 72, true);
                WriteLiteral("\r\n    <table><tr><td>Description Table</td></tr> </table>\r\n    <table>\r\n");
                EndContext();
#line 27 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
         foreach (var character in (ViewData["Description"] as List<MyProject.Models.DescSelect>))
        {

#line default
#line hidden
                BeginContext(693, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(732, 19, false);
#line 30 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
               Write(character.MovieName);

#line default
#line hidden
                EndContext();
                BeginContext(751, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(779, 22, false);
#line 31 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
               Write(character.DirectorName);

#line default
#line hidden
                EndContext();
                BeginContext(801, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(803, 26, false);
#line 31 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
                                       Write(character.DirectorLastName);

#line default
#line hidden
                EndContext();
                BeginContext(829, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(857, 19, false);
#line 32 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
               Write(character.ActorName);

#line default
#line hidden
                EndContext();
                BeginContext(876, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(878, 23, false);
#line 32 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
                                    Write(character.ActorLastName);

#line default
#line hidden
                EndContext();
                BeginContext(901, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(929, 21, false);
#line 33 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
               Write(character.Description);

#line default
#line hidden
                EndContext();
                BeginContext(950, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 35 "I:\Leopold Docs\C#\Study\Advance\MyProject\MyProject\Views\Home\Description.cshtml"
        }

#line default
#line hidden
                BeginContext(987, 299, true);
                WriteLiteral(@"    </table>
    <table>
        <tr><td><a href=""https://localhost:5001/home/ShowGenres"">Previous Table</a></td><td><a href=""https://localhost:5001/home/ShowMovies"">Next Table</a></td></tr>
    </table>

    <table><tr><td><a href=""https://localhost:5001/"">On Main Page</a></td></tr></table>
");
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
            BeginContext(1293, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
