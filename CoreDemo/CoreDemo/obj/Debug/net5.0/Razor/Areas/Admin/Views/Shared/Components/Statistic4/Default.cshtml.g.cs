#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "23393553816ad640c8c231e429efaffaac88e04b5bff757c7e50b1143eca24fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic4_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic4/Default.cshtml")]
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
#line 1 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"23393553816ad640c8c231e429efaffaac88e04b5bff757c7e50b1143eca24fb", @"/Areas/Admin/Views/Shared/Components/Statistic4/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e8c31420aecb313caaa426aed013ee110b98c50f7b146de83e253ab340189821", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic4_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n        <div class=\"widget-head-color-box navy-bg p-lg text-center\">\r\n            <div class=\"m-b-md\">\r\n                <h2 class=\"font-bold no-margins\">\r\n                    ");
            Write(
#nullable restore
#line 6 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml"
                     ViewBag.v1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </h2>\r\n                <small>Blog Creater</small>\r\n            </div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 339, "\"", 356, 1);
            WriteAttributeValue("", 345, 
#nullable restore
#line 10 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml"
                       ViewBag.v2

#line default
#line hidden
#nullable disable
            , 345, 11, false);
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded-circle circle-border m-b-md"" alt=""profile"">
            <div>
                <span>100 Tweets</span> |
                <span>350 Following</span> |
                <span>610 Followers</span>
            </div>
        </div>
        <div class=""widget-text-box"">
            <h4 class=""media-heading"">");
            Write(
#nullable restore
#line 18 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml"
                                       ViewBag.v1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n            <p>");
            Write(
#nullable restore
#line 19 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic4\Default.cshtml"
                ViewBag.v3

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n            <div class=\"text-right\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 789, "\"", 796, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-white\"><i class=\"fa fa-thumbs-up\"></i> Like </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 888, "\"", 895, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-primary""><i class=""fa fa-heart""></i> Love</a>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""widget navy-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-shield fa-4x""></i>
                <h1 class=""m-xs"">456</h1>
                <h3 class=""font-bold no-margins"">
                    Shield
                </h3>
                <small>power</small>
            </div>
        </div>
        <div class=""widget  p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-flash fa-4x""></i>
                <h1 class=""m-xs"">612</h1>
                <h3 class=""font-bold no-margins"">
                    Thunder
                </h3>
                <small>amount</small>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""widget lazur-bg p-xl"">

            <h2>
                Janet Smith
            </h2>
            ");
            WriteLiteral(@"<ul class=""list-unstyled m-t-md"">
                <li>
                    <span class=""fa fa-envelope m-r-xs""></span>
                    <label>Email:</label>
                    mike@mail.com
                </li>
                <li>
                    <span class=""fa fa-home m-r-xs""></span>
                    <label>Address:</label>
                    Street 200, Avenue 10
                </li>
                <li>
                    <span class=""fa fa-phone m-r-xs""></span>
                    <label>Contact:</label>
                    (+121) 678 3462
                </li>
            </ul>

        </div>
        <div class=""widget red-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-bell fa-4x""></i>
                <h1 class=""m-xs"">47</h1>
                <h3 class=""font-bold no-margins"">
                    Notification
                </h3>
                <small>We detect the error.</small>
            </div>
        </div>
    ");
            WriteLiteral(@"</div>
    <div class=""col-lg-2"">
        <div class=""widget yellow-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-thumbs-up fa-4x""></i>
                <h1 class=""m-xs"">520</h1>
                <h3 class=""font-bold no-margins"">
                    Likes
                </h3>
                <small>amount</small>
            </div>
        </div>
        <div class=""widget yellow-bg p-lg text-center"">
            <div class=""m-b-md"">
                <i class=""fa fa-warning fa-4x""></i>
                <h1 class=""m-xs"">Alarm</h1>
                <h3 class=""font-bold no-margins"">
                    Do
                </h3>
                <small>something</small>
            </div>
        </div>
    </div>
</div>");
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
