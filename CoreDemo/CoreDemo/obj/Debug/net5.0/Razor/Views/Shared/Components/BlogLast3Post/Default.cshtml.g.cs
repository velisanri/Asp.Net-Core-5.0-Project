#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "836b6787593db9a3cf752a04a564753d1cd518e7b243243acdfe8a39927ed1b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"836b6787593db9a3cf752a04a564753d1cd518e7b243243acdfe8a39927ed1b3", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"tech-btm\">\r\n    <h3>Latest Posts</h3>\r\n");
#nullable restore
#line 8 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 258, "\"", 295, 2);
            WriteAttributeValue("", 265, "/Blog/BlogReadAll/", 265, 18, true);
            WriteAttributeValue("", 283, 
#nullable restore
#line 12 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                            item.BlogID

#line default
#line hidden
#nullable disable
            , 283, 12, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 323, "\"", 344, 1);
            WriteAttributeValue("", 329, 
#nullable restore
#line 13 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                               item.BlogImage

#line default
#line hidden
#nullable disable
            , 329, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 376, "\"", 382, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 563, 2);
            WriteAttributeValue("", 533, "/Blog/BlogReadAll/", 533, 18, true);
            WriteAttributeValue("", 551, 
#nullable restore
#line 19 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                item.BlogID

#line default
#line hidden
#nullable disable
            , 551, 12, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 19 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                              item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" "))

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("... </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
            Write(
#nullable restore
#line 23 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                       ((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591