#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297402b8b8d17bd15f069177c2e3df6eb0277592"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_Company), @"mvc.1.0.view", @"/Views/Master/Company.cshtml")]
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
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297402b8b8d17bd15f069177c2e3df6eb0277592", @"/Views/Master/Company.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_Company : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCASA.Models.ModelClasses.CompanyDisplayModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EmpireHome/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
  
    int rCnt = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""row"">
            <div class=""col-md-11"">
                <div class=""header-icon"">
                    <i class=""fa fa-users""></i>
                </div>
                <div class=""header-title"">
                    <h1>Company </h1>
                    <small>Company List</small>
                </div>
            </div>
        <div class=""btn-group float-right"" role=""group"">
            <div class=""buttonexport"" id=""buttonlist"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297402b8b8d17bd15f069177c2e3df6eb02775924608", async() => {
                WriteLiteral("\r\n                    <i class=\"fa fa-reply mr-2\"></i> Back\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
</div>
    </section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-lg-12 pinpin"">
            <div class=""card"" data-sortable=""true"">
                <div class=""card-header"">
                    <div class=""card-title custom_title"">
                        <div class=""row"">
");
            WriteLiteral("\r\n                            <div class=\"col-md-9\">\r\n                                <h4>Company Details </h4>\r\n                            </div>\r\n");
            WriteLiteral("\r\n                            <div class=\"col-md-3\">\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>

                </div>
                <div class=""card-body"">
                    <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                    <div class=""table-responsive"">
                        <table id=""mydatatable"" class=""table table-bordered table-striped table-hover"">
                            <thead class=""back_table_color"">
                                <tr class=""info"">
                                    <th>#</th>
                                    <th>Company Name</th>
                                    <th>Company Address</th>
                                    <th>Warehouse Address</th>
                                    <th>Showroom Address</th>
                                    <th>CEO Name</th>
                                    <th>CEO Email</th>
                                    <th>CEO Number</th>
                                    <th>Warehouse N");
            WriteLiteral(@"umbers</th>
                                    <th>Showroom Numbers</th>
                                    <th>Warehouse Email</th>
                                    <th>Showroom Email</th>
                                    <th>GSTIN</th>
                                    <th>Code</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 100 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                 if (Model != null)
                                {
                                    foreach (var s in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 105 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                            Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 106 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 107 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 108 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.WarehouseAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 109 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.ShowroomAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 110 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.CEOName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 111 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.CEOEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 112 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.CEOContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 113 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.WarehousePhoneNumbers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 114 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.ShowroomPhoneNumbers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 115 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.WarehouseEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 116 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.ShowroomEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 117 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.GSTIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 118 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                           Write(s.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297402b8b8d17bd15f069177c2e3df6eb027759212869", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-add btn-sm\" title=\"Edit\"><i class=\"fa fa-pencil\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5566, "~/Master/CompanyData?id=", 5566, 24, true);
#nullable restore
#line 120 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
AddHtmlAttributeValue("", 5590, s.CompanyId, 5590, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 129 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\Company.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- /.content -->
</div>
<script>
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {
                $.ajax({
                    url: GlobalUrl + ""Master/DeleteCompany?id="" + id,
                    type: 'post',
                    data: '{}',
                    success: function (result) {
                        toastr[""success""](""Successuflly deleted!"");
                        window.location.href = window.location.href;
                    }
                });
            }
");
            WriteLiteral("            else {\r\n                toastr[\"error\"](\"Delete cancelled!\")\r\n            }\r\n            return false;\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCASA.Models.ModelClasses.CompanyDisplayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
