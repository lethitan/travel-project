#pragma checksum "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed0afffb01c4883528429dd598d0dc5477f8a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tourist_Detail), @"mvc.1.0.view", @"/Views/Tourist/Detail.cshtml")]
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
#line 6 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed0afffb01c4883528429dd598d0dc5477f8a93", @"/Views/Tourist/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Tourist_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eProject.Models.TouristSpot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "tourist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailSer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("details-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("More Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
  
    ViewData["Title"] = "detail";
    Layout = "~/Views/Share/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h2>Tourist Details</h2>
                <ol>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed0afffb01c4883528429dd598d0dc5477f8a937751", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li>Tourist detail</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Tourist Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
        <div class=""container"">
            <div class=""row gy-4"">

                <div class=""col-lg-8"">
                    <div class=""portfolio-details-slider swiper-container"">
                        <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 31 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                             foreach (var img in ViewBag.tourist.Imgs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ed0afffb01c4883528429dd598d0dc5477f8a9310026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1266, "~/Img/", 1266, 6, true);
#nullable restore
#line 34 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
AddHtmlAttributeValue("", 1272, img.Name, 1272, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 36 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>

                <div class=""col-lg-4"">
                    <div class=""portfolio-info"">
                        <h3>");
#nullable restore
#line 44 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                       Write(ViewBag.tourist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" information</h3>\r\n                        <ul>\r\n                            <li><strong>Address </strong>: ");
#nullable restore
#line 46 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                                      Write(ViewBag.tourist.Addr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Category </strong>: ");
#nullable restore
#line 47 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                                       Write(ViewBag.tourist.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"portfolio-description\">\r\n                        <h2>Description </h2>\r\n                        <p class=\"fst-italic\">\r\n                            ");
#nullable restore
#line 53 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                       Write(ViewBag.tourist.Descrip);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>

            </div>
            <div class=""portfolio-description"">
                <h2>Actives in tourist spot</h2>
                <p class=""fst-italic"">
                    ");
#nullable restore
#line 62 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
               Write(ViewBag.tourist.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </div>\r\n            <div>\r\n                <h4 class=\"d-none d-lg-block\">Related vehicles </h4>\r\n                <ul class=\"nav nav-tabs row d-flex\">\r\n");
#nullable restore
#line 69 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                     foreach (var travel in ViewBag.tourist.TourTravels)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item col-3\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n                            <a class=\"nav-link\" data-bs-toggle=\"tab\" href=\"#tab-2\">\r\n                                <i class=\"ri-body-scan-line\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ed0afffb01c4883528429dd598d0dc5477f8a9314707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2970, "~/Img/", 2970, 6, true);
#nullable restore
#line 73 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
AddHtmlAttributeValue("", 2976, travel.Travel.Img, 2976, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i>\r\n                                <h4 class=\"d-none d-lg-block\">");
#nullable restore
#line 74 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                                         Write(travel.Travel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 77 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
        </div>

    </section><!-- End Portfolio Details Section -->
    <!-- ======= Restaurant & hotel Section ======= -->
    <section id=""team"" class=""team"">
        <div class=""container"">

            <div class=""section-title"" data-aos=""zoom-out"">
                <h2>Restaurant and Hotel</h2>
                <p>Where you can rest</p>
            </div>
            <div class=""row"">
");
#nullable restore
#line 92 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                 foreach (var sevice in ViewBag.tourist.Servis)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                     if (sevice.Stt == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 3833, "\"", 3911, 6);
            WriteAttributeValue("", 3841, "col-lg-3", 3841, 8, true);
            WriteAttributeValue(" ", 3849, "col-md-6", 3850, 9, true);
            WriteAttributeValue(" ", 3858, "d-flex", 3859, 7, true);
            WriteAttributeValue(" ", 3865, "align-items-stretch", 3866, 20, true);
            WriteAttributeValue(" ", 3885, "filter-", 3886, 8, true);
#nullable restore
#line 96 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
WriteAttributeValue("", 3893, sevice.CategoryId, 3893, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"member\" data-aos=\"fade-up\">\r\n\r\n                                <div class=\"member-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ed0afffb01c4883528429dd598d0dc5477f8a9318800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4090, "~/Img/", 4090, 6, true);
#nullable restore
#line 100 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
AddHtmlAttributeValue("", 4096, sevice.Imgs[0].Name, 4096, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"social\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed0afffb01c4883528429dd598d0dc5477f8a9320534", async() => {
                WriteLiteral("<i class=\"bx bx-link\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                                                                             WriteLiteral(sevice.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"member-info\">\r\n                                    <h4>");
#nullable restore
#line 106 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                   Write(sevice.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <span>");
#nullable restore
#line 107 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                     Write(sevice.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 111 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
    </section>
    <!-- End Restaurant & hotel Section -->
    <!-- Comments Section -->
    <section id=""team"" class=""team"">
        <div class=""container"">
            <h2 style=""text-align:center""><i>Comment</i></h2>
            <div class=""section-title"" data-aos=""zoom-out"">
");
#nullable restore
#line 123 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                 if (Context.Session.GetString("username") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed0afffb01c4883528429dd598d0dc5477f8a9324938", async() => {
                WriteLiteral(@"
                        <div class=""col-md-7 col-sm-5 col-xs-12 form-group pull-right top_search"">
                            <div class=""input-group"">
                                <input type=""text"" name=""Content"" class=""form-control"" placeholder=""Your comment..."">
                                <span class=""input-group-btn"">
                                    <input type=""submit"" class=""btn btn-secondary"" value=""Go !"" />
                                    <input type=""hidden"" name=""TourId""");
                BeginWriteAttribute("value", " value=\"", 5826, "\"", 5853, 1);
#nullable restore
#line 131 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
WriteAttributeValue("", 5834, ViewBag.tourist.Id, 5834, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 137 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 139 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
             foreach (var cmt in ViewBag.tourist.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><b>");
#nullable restore
#line 141 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                 Write(cmt.Acc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</b> ");
#nullable restore
#line 141 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
                                     Write(cmt.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 142 "C:\eProject\eProject\eProject\Views\Tourist\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n</main><!-- End #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eProject.Models.TouristSpot> Html { get; private set; }
    }
}
#pragma warning restore 1591
