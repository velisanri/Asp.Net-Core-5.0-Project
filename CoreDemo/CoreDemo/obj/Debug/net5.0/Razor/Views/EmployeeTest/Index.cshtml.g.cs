#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ebe548f4e329396c0cf6e7e6b637f2c7764315bf8587e315fa33456b1258b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
 using CoreDemo.Controllers

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8ebe548f4e329396c0cf6e7e6b637f2c7764315bf8587e315fa33456b1258b85", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreDemo.Controllers.EmployeeTestController.Class1>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı Soyadı</th>\r\n        <th>Sil</th>\r\n        <th>Düzenle</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n\r\n            <td>");
            Write(
#nullable restore
#line 24 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                 item.ID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 25 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 493, "\"", 537, 2);
            WriteAttributeValue("", 500, "/EmployeeTest/DeleteEmployee/", 500, 29, true);
            WriteAttributeValue("", 529, 
#nullable restore
#line 26 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                                                       item.ID

#line default
#line hidden
#nullable disable
            , 529, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 602, "\"", 644, 2);
            WriteAttributeValue("", 609, "/EmployeeTest/EditEmployee/", 609, 27, true);
            WriteAttributeValue("", 636, 
#nullable restore
#line 27 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
                                                     item.ID

#line default
#line hidden
#nullable disable
            , 636, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n</table>\r\n\r\n<td><a href=\"/EmployeeTest/AddEmployee/\" class=\"btn btn-outline-primary\">Yeni Çalışan</a></td>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreDemo.Controllers.EmployeeTestController.Class1>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
