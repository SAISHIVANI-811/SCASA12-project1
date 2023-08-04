#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\EmpireHome\DailySalesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf8345105f87be353ca34c1bf422aef084ef3622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpireHome_DailySalesReport), @"mvc.1.0.view", @"/Views/EmpireHome/DailySalesReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8345105f87be353ca34c1bf422aef084ef3622", @"/Views/EmpireHome/DailySalesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_EmpireHome_DailySalesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.ProductDisplaySalesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/EmpireHome/SaleExecutiveReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\EmpireHome\DailySalesReport.cshtml"
  
    string[] months = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
    DateTime dtfrom = new DateTime();
    dtfrom = DateTime.Now;
    DateTime dt = new DateTime(dtfrom.Year, dtfrom.Month, 1);
    int maxdt = (new DateTime(dtfrom.Year, dtfrom.Month, 1).AddMonths(1).AddDays(-1)).Day;
    int dtCount = 0;
    int todayDay = dtfrom.Day;
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Sales Report - Daily Product Wise</h1>
            <small></small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">

        <div class=""row"">
");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"            <div class=""col-lg-12 pinpin ui-sortable"" data-lobicard-child-inner-id=""4IovlaQMiI"">
                <div class=""card"" data-sortable=""true"" data-inner-id=""4IovlaQMiI"" data-index=""0"" style=""display: block;"">
                    <div class=""card-header ui-sortable-handle"">
                        <div class=""card-title custom_title"" style=""max-width: calc(100% + 0px);"">
                            <div class=""btn-group buttonexport d-flex"" role=""group"">

                                <h4>Day Report - ");
#nullable restore
#line 40 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\EmpireHome\DailySalesReport.cshtml"
                                             Write(DateTime.Now.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <!-- ./Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <div class=""table-responsive"">
                            <table id=""dataTableExample1"" class=""table table-bordered table-striped table-hover"">
                                <thead class=""back_table_color"">
                                    <tr class=""info"">
                                        <th>Sales Executive</th>
                                        <th>Customer Name</th>
                                        <th colspan=""4"">Product Category</th>
                                        <th>Status</th>
                                        <th>Quote Value</th>
                                        <th>Sale Value</th>
                                        <th>Receipts</th>
                                    </tr>
         ");
            WriteLiteral(@"                           <tr>

                                        <th></th>
                                        <th></th>
                                        <th>
                                            Accessories
                                        </th>
                                        <th>Beds</th>
                                        <th>Tables</th>
                                        <th>Chairs</th>
                                        <th></th>
                                        <th></th>
                                        <th></th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>

                                    <tr>
                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8345105f87be353ca34c1bf422aef084ef36227497", async() => {
                WriteLiteral("Durga");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</td>
                                        <td>Mahipal Reddy</td>
                                        <td>0</td>
                                        <td class=""text-right"">0</td>
                                        <td class=""text-right"">100000</td>
                                        <td class=""text-right"">0</td>
                                        <td class=""text-center"">Purchased</td>
                                        <td class=""text-right"">1000000</td>
                                        <td class=""text-right"">1000000</td>
                                        <td class=""text-right"">1000000</td>
                                    </tr>
                                    <tr>
                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8345105f87be353ca34c1bf422aef084ef36229363", async() => {
                WriteLiteral("Durga");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</td>
                                        <td>Chandra Sekahr</td>

                                        <td>0</td>
                                        <td class=""text-right"">0</td>
                                        <td class=""text-right"">100000</td>
                                        <td class=""text-right"">0</td>
                                        <td class=""text-center"">Not purchased</td>
                                        <td class=""text-right"">1000000</td>
                                        <td class=""text-right"">0</td>
                                        <td class=""text-right"">0</td>
                                    </tr>


                                <thead class=""back_table_color"">
                                    <tr class=""info"">

                                        <th>Total Day Report</th>
                                        <th></th>
                                        <th class=""text-right"">0</th>
                  ");
            WriteLiteral(@"                      <th class=""text-right"">0</th>
                                        <th class=""text-right"">100000</th>
                                        <th class=""text-right"">0</th>
                                        <th></th>
                                        <th class=""text-right"">1000000</th>
                                        <th class=""text-right"">1000000</th>
                                        <th class=""text-right"">1000000</th>
                                    </tr>
                                </thead>
                                </tbody>
                            </table>
                        </div>



                    </div>
                </div>
            </div>

            <div class=""col-lg-12 pinpin ui-sortable"" data-lobicard-child-inner-id=""4IovlaQMiI"">
                <div class=""card"" data-sortable=""true"" data-inner-id=""4IovlaQMiI"" data-index=""0"" style=""display: block;"">
                    <div class=""card-header ");
            WriteLiteral(@"ui-sortable-handle"">
                        <div class=""card-title custom_title"" style=""max-width: calc(100% + 0px);"">
                            <div class=""btn-group buttonexport d-flex"" role=""group"">

                                <h4>Sales Exectuives Performance</h4>

                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <!-- ./Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <div>

                            <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
                            <script type=""text/javascript"">

                                window.onload = function () {
                                    var chart = new CanvasJS.Chart(""chartContainer"", {
                                        title: {
                                            text: ""Sales Exectutives Performance for the Day""
                      ");
            WriteLiteral(@"                  },
                                        data: [
                                            {
                                                // Change type to ""doughnut"", ""line"", ""splineArea"", etc.
                                                type: ""column"",
                                                dataPoints: [
                                                    { label: ""Mahipal"", y: 50000000 },
                                                    { label: ""Vishnu"", y: 25000000 },
                                                    { label: ""Ramesh"", y: 5000000 },
                                                    { label: ""Rakesh"", y: 2400000 },
                                                    { label: ""sudhakar"", y: 10000000 }


                                                ]
                                            }
                                        ]
                                    });
                                    chart.render();");
            WriteLiteral(@"
                                }
                            </script>

                            <div id=""chartContainer"" style=""height: 300px; width: 50%;"">

                            </div>
                        </div>


                    </div>
                </div>
            </div>

        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.ProductDisplaySalesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
