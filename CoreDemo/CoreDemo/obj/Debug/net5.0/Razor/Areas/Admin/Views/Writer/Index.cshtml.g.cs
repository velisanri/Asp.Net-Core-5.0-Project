#pragma checksum "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "14f3c07c3aca45182ecf1feedaffab7c18b7902f95e3d3ad24d7b7fed6438210"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"14f3c07c3aca45182ecf1feedaffab7c18b7902f95e3d3ad24d7b7fed6438210", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e8c31420aecb313caaa426aed013ee110b98c50f7b146de83e253ab340189821", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Veli Sanrı\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1>Ajax</h1>

<br />

<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary""> Writer Lists </button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success""> Writer Incomes </button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info""> Writer Add </button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger""> Writer Remove </button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning""> Writer Update </button>
<br />
<br />

<div id=""writerlist"">
    Writers income
</div>

<br />

<div id=""writerget"">
    Ones Writers
</div>

<br />

<div>
    <input type=""text"" id=""writerid"" placeholder=""Writer ID Inputs"" class=""form-control"" />
</div>

<br />

<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID"" />
    <br />
    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar Adı"" />
</div>

<br />

<div>
    <input type=""text"" c");
            WriteLiteral(@"lass=""form-control"" id=""txtid"" placeholder=""Silinecek Yazar ID"" />
    
</div>

<br />

<input type=""text"" id=""txtid1"" class=""form-control"" placeholder=""Güncellenecek ID"" />
<input type=""text"" id=""txtwritername1"" class=""form-control"" placeholder=""Güncellenecek isim"" />



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered> <tr><th> Yazar ID </th> <th> Yazar Adı </th> </tr>""

                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td> <tr>`
                    });

                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
");
                WriteLiteral(@"                type: ""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class=table table-bordered <tr><th>Yazar ID</th> <th>Yazar Adı> </th></tr>  <tr><td>${w.Id} </td><td>${w.Name}</td></tr></table>  `
                    $(""#writerget"").html(getvalue);
                }
            });

        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val(),
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar eklendi"");
          ");
                WriteLiteral(@"      }
            });

        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silindi"");
                 }
        });
       });

        $(""btnupdatewriter"").click(function () {
            let writer = {
                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (funk) {
                    alert(""Güncelleme yapildi"")
                }
            });

        });


    </script>
");
            }
            );
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