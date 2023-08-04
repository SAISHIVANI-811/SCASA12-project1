#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da0a9c7b0c3e2e31e031e72e22d945495ac6822"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_PrintLedgerTransaction), @"mvc.1.0.view", @"/Views/Finance/PrintLedgerTransaction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da0a9c7b0c3e2e31e031e72e22d945495ac6822", @"/Views/Finance/PrintLedgerTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_PrintLedgerTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.LedgerScreenModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Cabin\', Arial, \'Helvetica Neue\', Helvetica, sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
  
    Layout = null;
    decimal dTot = 0;
    decimal CTot = 0;
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da0a9c7b0c3e2e31e031e72e22d945495ac68224301", async() => {
                WriteLiteral(@"
    <!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
    <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"" />
    <meta content=""width=device-width"" name=""viewport"" />
    <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=""X-UA-Compatible"" />
    <!--<![endif]-->
    <title>Ledger</title>
    <!--[if !mso]><!-->
    <!--<![endif]-->

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da0a9c7b0c3e2e31e031e72e22d945495ac68225747", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        body {
            margin: 0;
            padding: 0;
            background-color: rgb(237, 237, 240);
        }

        table,
        td,
        tr {
            vertical-align: top;
            border-collapse: collapse;
        }

        * {
            line-height: inherit;
        }

        a[x-apple-data-detectors=true] {
            color: inherit !important;
            text-decoration: none !important;
        }
    </style>
    <table width=""800px"" style=""margin: 0 auto; border:2px solid #a3080d;background-color: #fff;"" cellspacing=""0"" cellpadding=""0"">
        <tbody>
            <tr>
                <td style=""padding: 10px;"">
                    <table width=""100%;"">
                        <tbody>
                            <tr>
                                <td style=""text-align: center; font-size: 24px; font-weight: bold;"">SCASA</td>
                            </tr>
                            <tr>
                ");
                WriteLiteral("                <td style=\"text-align: center; font-size:16px;\">\r\n                                    ");
#nullable restore
#line 58 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                               Write(Model.companyDetails.CompanyAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"text-align: center; font-size: 22px; font-weight: bold;\">");
#nullable restore
#line 62 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                                               Write(Model.headName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td style=\"text-align: center; font-size:16px;\">\r\n                                   ");
#nullable restore
#line 66 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                              Write(Model.headAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                              
                                DateTime fr = Convert.ToDateTime(Model.FromDate);
                                DateTime tr = Convert.ToDateTime(Model.ToDate);
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"text-align: center; font-size: 18px;  font-weight: bold; padding-top:20px; text-decoration: underline\">");
#nullable restore
#line 74 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                                                                                             Write(fr.ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" to ");
#nullable restore
#line 74 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                                                                                                                            Write(tr.ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                            </tr>
                            <tr>
                                <td style=""height: 30px;""></td>
                            </tr>
                            <tr>
                                <td>
                                    <table width=""100%"">
                                        <tbody bgcolor=""#56DCFF"" border=""1"">
                                        <th style=""border:1px solid #000;"">Date</th>
                                        <th style=""border:1px solid #000;"">Particulars</th>
                                        <th style=""border:1px solid #000;"">Vch Type</th>
                                        <th style=""border:1px solid #000;"">Vch No.</th>
                                        <th style=""border:1px solid #000;"">Debit</th>
                                        <th style=""border:1px solid #000;"">Credit</th>
                        </tbody>
                        <tbody style=""font-size: 13px;"">
");
#nullable restore
#line 91 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                             foreach (var t in Model.Ledgers)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 94 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                      
                                        DateTime co = Convert.ToDateTime(t.DateOfTransaction);
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 97 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                   Write(co.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 98 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                     if (t.VoucherType == "Payment")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td data-title=\"Particulars\"> ");
#nullable restore
#line 100 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                 Write(t.FromHeadID_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 101 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                    }
                                    else if (t.VoucherType == "Receipt")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td data-title=\"Particulars\"> ");
#nullable restore
#line 104 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                 Write(t.FromHeadID_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 105 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>");
#nullable restore
#line 106 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                   Write(t.VoucherType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 107 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                   Write(t.VoucherNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 108 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                   Write(t.Debit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td><strong>");
#nullable restore
#line 109 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                           Write(t.Credit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 110 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                      
                                        dTot += (decimal)t.Debit;
                                        CTot += (decimal)t.Credit;
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 115 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <tr>
                                <td style=""height: 10px""></td>
                            </tr>
                            <tr>
                                <td colspan=""4""></td>
                                <td style=""border-bottom:1px solid #000; border-top:1px solid #000;""><strong>");
#nullable restore
#line 122 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                                                        Write(String.Format(Indian, "{0:N}", dTot));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                                <td style=\"border-bottom:1px solid #000; border-top:1px solid #000;\"><strong>");
#nullable restore
#line 123 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\PrintLedgerTransaction.cshtml"
                                                                                                        Write(String.Format(Indian, "{0:N}", CTot));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                            </tr>\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    </td>\r\n    </tr>\r\n\r\n    </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.LedgerScreenModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
