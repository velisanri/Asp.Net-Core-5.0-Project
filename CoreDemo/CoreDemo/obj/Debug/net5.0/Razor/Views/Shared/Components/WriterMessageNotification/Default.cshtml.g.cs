#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c705ef80d18332d8262fc61917d6a03ec5e3bb6150a83b70bf3760ffe77b956e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
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
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c705ef80d18332d8262fc61917d6a03ec5e3bb6150a83b70bf3760ffe77b956e", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Messages</h6>\r\n    <div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 7 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
     if (Model != null && Model.Any())
    {
        

#line default
#line hidden
#nullable disable

#nullable restore
#line 9 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <a class=\"dropdown-item preview-item\">\r\n                <div class=\"preview-thumbnail\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 469, "\"", 504, 2);
            WriteAttributeValue("", 475, 
#nullable restore
#line 13 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                               item.SenderUser.WriterImage

#line default
#line hidden
#nullable disable
            , 475, 28, false);
            WriteAttributeValue(" ", 503, "", 504, 1, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n                </div>\r\n                <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
            Write(
#nullable restore
#line 16 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                                  item.SenderUser.WriterName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Message You</h6>\r\n                    <p class=\"text-gray mb-0\"> ");
            Write(
#nullable restore
#line 17 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                item.MessageDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </p>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 20 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 20 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p class=\"p-3 mb-0 text-center\">No messages available</p>\r\n");
#nullable restore
#line 25 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h6 class=\"p-3 mb-0 text-center\">4 new messages</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
