#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "faa5bbb708cfc7ff5fd8f66a15a76084348f17df533ba0b45486ae510dd778d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendBox), @"mvc.1.0.view", @"/Views/Message/SendBox.cshtml")]
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
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"faa5bbb708cfc7ff5fd8f66a15a76084348f17df533ba0b45486ae510dd778d1", @"/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table>\r\n    class=\"table table-bordored\"\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Alıcı</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı </th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <th>");
            Write(
#nullable restore
#line 20 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
                 item.MessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n            <td>");
            Write(
#nullable restore
#line 21 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
                 item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 22 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
                 item.ReceiverUser.WriterName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 23 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
                  ((DateTime)item.MessageDate).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 586, "\"", 632, 2);
            WriteAttributeValue("", 593, "/Message/MessageDetails/", 593, 24, true);
            WriteAttributeValue("", 617, 
#nullable restore
#line 24 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
                                                  item.MessageID

#line default
#line hidden
#nullable disable
            , 617, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Message\SendBox.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n\r\n<a href=\"/MessageController/SendMessage/\" class=\"btn btn-info\"> Yeni Mesaj Oluştur </a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
