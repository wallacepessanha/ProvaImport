#pragma checksum "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3077a246331b985ff72b227a153f44955196605a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StatementBank), @"mvc.1.0.view", @"/Views/Home/StatementBank.cshtml")]
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
#nullable restore
#line 1 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\_ViewImports.cshtml"
using ExameImport.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\_ViewImports.cshtml"
using ExameImport.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077a246331b985ff72b227a153f44955196605a", @"/Views/Home/StatementBank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb1e874507e698c80d41702a1080526bbc247dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StatementBank : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExameImport.Web.ViewModels.StatementViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
  
    ViewData["Title"] = "Statement Bank";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"container\">\r\n    \r\n    <div class=\"row\">        \r\n\r\n");
#nullable restore
#line 11 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
         if (Model != null && Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-hover\">\r\n                <thead class=\"thead-dark\">\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 17 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                       Write(Html.DisplayNameFor(model => model.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 20 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead >\r\n                <tbody>\r\n");
#nullable restore
#line 32 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr ");
#nullable restore
#line 34 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                        Write(new { @Class= (item.Action == "DEBIT")? "badge-danger":"badge-success"  });

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                            <td>\r\n                                ");
#nullable restore
#line 36 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 51 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Could not get any result</p>\r\n");
#nullable restore
#line 55 "D:\Projeto\ProvaImport\src\ExameImport\ExameImport.Web\Views\Home\StatementBank.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExameImport.Web.ViewModels.StatementViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
