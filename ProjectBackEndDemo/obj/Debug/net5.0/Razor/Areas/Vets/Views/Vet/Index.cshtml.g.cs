#pragma checksum "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b90c460f813efd240620da7fab8a4a61ed4228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Vets_Views_Vet_Index), @"mvc.1.0.view", @"/Areas/Vets/Views/Vet/Index.cshtml")]
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
#line 1 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
using ProjectBackEndDemo.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
using ProjectBackEndDemo.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b90c460f813efd240620da7fab8a4a61ed4228", @"/Areas/Vets/Views/Vet/Index.cshtml")]
    public class Areas_Vets_Views_Vet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjectBackEndDemo.Areas.Vets.Models.VetVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/allvets.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/allvets-ar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Vets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewVet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/allvets.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
  
    var Culuture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
    ViewData["Title"] = @AppLng["Vets"];
    Layout = "~/Views/Layouts/MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07b90c460f813efd240620da7fab8a4a61ed42286351", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 20 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
 if (Culuture == "ar-EG")
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07b90c460f813efd240620da7fab8a4a61ed42287715", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"vet-section\">\r\n    <h3 class=\"heading\"> ");
#nullable restore
#line 27 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                    Write(AppLng["All vets"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h3>\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 29 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"vet-box\">\r\n                <picture>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 996, "\"", 1037, 2);
            WriteAttributeValue("", 1002, "/Files/VetPictures/", 1002, 19, true);
#nullable restore
#line 33 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
WriteAttributeValue("", 1021, item.PictureUrl, 1021, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1038, "\"", 1044, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </picture>\r\n                <div class=\"box-header\">\r\n                    <span class=\"vet-name\">\r\n                        ");
#nullable restore
#line 37 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                    <span class=\"vet-speciality\">\r\n                        ");
#nullable restore
#line 40 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                   Write(item.Speciality);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                    <span class=\"vet-address\">\r\n                        <address>");
#nullable restore
#line 43 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</address>\r\n                    </span>\r\n                </div>\r\n                <div class=\"box-content\">\r\n                    <div class=\"vet-info name-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5> ");
#nullable restore
#line 49 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(AppLng["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            ");
#nullable restore
#line 52 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"vet-info age-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5> ");
#nullable restore
#line 57 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(AppLng["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            ");
#nullable restore
#line 60 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                       Write(item.age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Years\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"vet-info speciality-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5> ");
#nullable restore
#line 65 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(AppLng["Speciality"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            ");
#nullable restore
#line 68 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                       Write(item.Speciality);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"vet-info address-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5> ");
#nullable restore
#line 73 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(AppLng["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            <address>");
#nullable restore
#line 76 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                                Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</address>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"vet-info phone-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5> ");
#nullable restore
#line 82 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                            Write(AppLng["Phone Number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            <a href=\"tel:01060170368\">\r\n                                <i class=\"fa-solid fa-phone\"></i> ");
#nullable restore
#line 86 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                                                             Write(item.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"vet-info gmail-info\">\r\n                        <div class=\"info-title\">\r\n                            <h5>");
#nullable restore
#line 92 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                           Write(AppLng["View vet Profile"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"info-value\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b90c460f813efd240620da7fab8a4a61ed422816582", async() => {
                WriteLiteral("\r\n                                <i class=\"fa-solid fa-user\"></i> ");
#nullable restore
#line 96 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                                                            Write(AppLng["View Vet Profile"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   \r\n                </div>\r\n\r\n               \r\n\r\n            </div>\r\n");
#nullable restore
#line 106 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <span class=\"vet-link more\">\r\n        <span> ");
#nullable restore
#line 110 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Vets\Views\Vet\Index.cshtml"
          Write(AppLng["View More"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n        <i class=\"fa-solid fa-angles-down\"></i>\r\n    </span>\r\n</div>\r\n\r\n\r\n\r\n<script src=\"/js/jquery-3.6.0.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07b90c460f813efd240620da7fab8a4a61ed422820459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> AppLng { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjectBackEndDemo.Areas.Vets.Models.VetVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
