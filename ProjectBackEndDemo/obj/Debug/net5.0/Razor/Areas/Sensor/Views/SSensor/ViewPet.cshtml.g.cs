#pragma checksum "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef70e7b452549e1db66b9ab065ebf5ffe08ff10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Sensor_Views_SSensor_ViewPet), @"mvc.1.0.view", @"/Areas/Sensor/Views/SSensor/ViewPet.cshtml")]
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
#line 4 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
using ProjectBackEndDemo.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef70e7b452549e1db66b9ab065ebf5ffe08ff10", @"/Areas/Sensor/Views/SSensor/ViewPet.cshtml")]
    public class Areas_Sensor_Views_SSensor_ViewPet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBackEndDemo.Areas.Sensor.Models.UserAnimalVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewpet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/viewpet-ar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Sensor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SSensor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPetProfilePicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPetProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viewpet.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
  
    ViewData["Title"] = AppLng["Pet"];
    Layout = "~/Views/Layouts/MainLayout.cshtml";
    var Culuture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
    if (Model.pictureSrc == null)
    {
        Model.pictureSrc = "DefaultPhoto.jpg";
    }


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ef70e7b452549e1db66b9ab065ebf5ffe08ff106373", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
 if (Culuture == "ar-EG")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ef70e7b452549e1db66b9ab065ebf5ffe08ff107739", async() => {
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
#line 22 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"viewprofile\">\r\n    <h3 class=\"heading\"> ");
#nullable restore
#line 26 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
                    Write(AppLng["View Pet Profile"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n    <div class=\"container\">\r\n        <div class=\"viewprofile-picture\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 848, "\"", 897, 2);
            WriteAttributeValue("", 854, "/Files/UserAnimalPictures/", 854, 26, true);
#nullable restore
#line 29 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
WriteAttributeValue("", 880, Model.pictureSrc, 880, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"profile\" class=\"viewprofile-img\">\r\n            <div class=\"viewprofile-link\">\r\n                <i class=\"fa-solid fa-camera\"></i>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef70e7b452549e1db66b9ab065ebf5ffe08ff1010155", async() => {
#nullable restore
#line 32 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
                                                                                            Write(AppLng["Edit Picture"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"profile-box pet-type\">\r\n            <div class=\"box-title\">\r\n                <h5>");
#nullable restore
#line 37 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
               Write(AppLng["Pet Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            </div>\r\n            <div class=\"box-value\">\r\n                ");
#nullable restore
#line 40 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
           Write(Model.AnimalType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"profile-box pet-name\">\r\n            <div class=\"box-title\">\r\n                <h5>");
#nullable restore
#line 45 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
               Write(AppLng["Pet Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            </div>\r\n            <div class=\"box-value\">\r\n              ");
#nullable restore
#line 48 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"profile-box pet-gender\">\r\n            <div class=\"box-title\">\r\n                <h5>");
#nullable restore
#line 53 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
               Write(AppLng["Pet gender"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            </div>\r\n            <div class=\"box-value\">\r\n                ");
#nullable restore
#line 56 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
           Write(Model.AnimalGenderType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n       \r\n        <div class=\"profile-box pet-age\">\r\n            <div class=\"box-title\">\r\n                <h5>");
#nullable restore
#line 62 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
               Write(AppLng["Pet Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"box-value\">\r\n              ");
#nullable restore
#line 65 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
         Write(Model.AnimalStringAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n      \r\n        <div class=\"profile-box viewprofile-edit\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef70e7b452549e1db66b9ab065ebf5ffe08ff1015146", async() => {
                WriteLiteral(" ");
#nullable restore
#line 70 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Sensor\Views\SSensor\ViewPet.cshtml"
                                                                                  Write(AppLng["Edit Pet Profile"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n<script src=\"/js/jquery-3.6.0.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef70e7b452549e1db66b9ab065ebf5ffe08ff1017115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBackEndDemo.Areas.Sensor.Models.UserAnimalVM> Html { get; private set; }
    }
}
#pragma warning restore 1591