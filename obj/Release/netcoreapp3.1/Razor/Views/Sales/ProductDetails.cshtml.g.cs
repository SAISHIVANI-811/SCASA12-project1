#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f680c6ce74638a3ec3c636ddfdf951e7911327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_ProductDetails), @"mvc.1.0.view", @"/Views/Sales/ProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f680c6ce74638a3ec3c636ddfdf951e7911327", @"/Views/Sales/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.SalesProductDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sales/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/shape1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Shape"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/shape2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
  
    Layout = "~/Views/Shared/_SalesMaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <div class=""page-title-area"">
        <div class=""d-table"">
            <div class=""d-table-cell"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-10"">
                            <div class=""title-content"">
                                <h2>Product Details > ");
#nullable restore
#line 12 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <ul>\r\n                                    <li>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65f680c6ce74638a3ec3c636ddfdf951e79113275860", async() => {
                WriteLiteral("Home");
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
            WriteLiteral(@"
                                    </li>
                                    <li>
                                        <span>Single Product</span>
                                    </li>
                                </ul>
                                
                            </div>
                        </div>
                        <div class=""col-md-2"">
");
            WriteLiteral(@"                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>

    <div class=""product-details-area ptb-60"">
        <div class=""container"">
            <div class=""top"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-8"">                       
                        <div id=""sync1"" class=""owl-carousel owl-theme"">
                            <div class=""item is-active"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e79113277919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2417, "~/ProductImages//", 2417, 17, true);
#nullable restore
#line 52 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 2434, Model.MainImage1, 2434, 17, false);

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
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 54 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                             foreach (var i in Model.MainImagesList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e79113279824", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2692, "~/ProductImages//", 2692, 17, true);
#nullable restore
#line 57 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 2709, i, 2709, 2, false);

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
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 59 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                             if (Model.OtherImages.Count > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 foreach (var oi in Model.OtherImages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132712200", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3095, "~/ProductImages//", 3095, 17, true);
#nullable restore
#line 65 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 3112, oi.ImageURL, 3112, 12, false);

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
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 67 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                        <div id=\"sync2\" class=\"owl-carousel owl-theme\">\r\n                            <div class=\"item is-active\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132714379", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3443, "~/ProductImages//", 3443, 17, true);
#nullable restore
#line 73 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 3460, Model.MainImage1, 3460, 17, false);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 75 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                            foreach (var i in Model.MainImagesList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132716280", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3713, "~/ProductImages/", 3713, 16, true);
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 3729, i, 3729, 2, false);

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
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 80 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                            if (Model.OtherImages.Count > 0)
                            {
                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                foreach (var oi in Model.OtherImages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132718653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4113, "~/ProductImages/", 4113, 16, true);
#nullable restore
#line 86 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 4129, oi.ImageURL, 4129, 12, false);

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
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 88 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        <div class=\"top-content\">\r\n                            <h2>");
#nullable restore
#line 94 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <h5>Model Number : ");
#nullable restore
#line 95 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                          Write(Model.ModelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h5>Brand Name: ");
#nullable restore
#line 96 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                       Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                                Dimensions : <span>\r\n                                    ");
#nullable restore
#line 99 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                               Write(Model.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Height)\r\n                                </span> X\r\n\r\n                                <span>");
#nullable restore
#line 102 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 Write(Model.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Width)</span> X <span> ");
#nullable restore
#line 102 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                                      Write(Model.Breadth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Breadth)</span>\r\n                            </p>\r\n\r\n                            <ul class=\"tag\">\r\n");
            WriteLiteral("                                <li>Category: <span>");
#nullable restore
#line 107 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                               Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 107 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                                     Write(Model.SubCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>\r\n                                    MRP : ");
#nullable restore
#line 109 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                            
                                        System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
                                        string mrp = String.Format(Indian, "{0:N}", Model.MRPPrice);
                                        //string price = String.Format(Indian, "{0:N}", Model.ActualPrice);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    Rs. ");
#nullable restore
#line 114 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                   Write(mrp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                                <li>Available Qty: <span>");
#nullable restore
#line 116 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                    Write(Model.WharehouseQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (W), ");
#nullable restore
#line 116 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                                              Write(Model.ShowroomQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (S), ");
#nullable restore
#line 116 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                                                                      Write(Model.ReservedQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (R)</span></li>\r\n                                <input type=\"hidden\" id=\"availableQty\"");
            BeginWriteAttribute("value", " value=\"", 5943, "\"", 5993, 1);
#nullable restore
#line 117 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
WriteAttributeValue("", 5951, Model.WharehouseQty + Model.ShowroomQty, 5951, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <li>Color : ");
#nullable restore
#line 118 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                       Write(Model.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 119 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                   
                                    var cimg = Model.ColorImage.Split(",");
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li> \r\n");
#nullable restore
#line 123 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 foreach (var ci in cimg)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132726894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6409, "~/ProductImages/", 6409, 16, true);
#nullable restore
#line 125 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 6425, ci, 6425, 3, false);

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
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                            <ul class=""cart"">
                                <li>
                                    <ul class=""number"">
                                        <li>
                                            <span class=""minus"">-</span>
                                            <input type=""text"" id=""prdQty"" value=""1"" />
                                            <span class=""plus"">+</span>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <a class=""common-btn"" href=""javascript:void(0)""");
            BeginWriteAttribute("onclick", " onclick=\"", 7183, "\"", 7222, 3);
            WriteAttributeValue("", 7193, "AddToCart(", 7193, 10, true);
#nullable restore
#line 139 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
WriteAttributeValue("", 7203, Model.InventoryId, 7203, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7221, ")", 7221, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Add To Cart\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132730016", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65f680c6ce74638a3ec3c636ddfdf951e791132731170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                            </ul>\r\n                            <h4>Documents</h4>\r\n                            <ol class=\"uploadDocs\">\r\n");
#nullable restore
#line 149 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                 foreach (var d in Model.DocsUploaded)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65f680c6ce74638a3ec3c636ddfdf951e791132732843", async() => {
#nullable restore
#line 151 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                                                        Write(d.DocumentName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7933, "~/ProductImages/", 7933, 16, true);
#nullable restore
#line 151 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
AddHtmlAttributeValue("", 7949, d.DocumentURL, 7949, 14, false);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 152 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""bottom"">

                <div>
                    <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab"">
                        <div class=""bottom-description"">
                            <h4>Description</h4>
                            <p>");
#nullable restore
#line 167 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\ProductDetails.cshtml"
                          Write(Model.ItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                             \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("\r\n<script>\r\n     \r\n</script>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.SalesProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
