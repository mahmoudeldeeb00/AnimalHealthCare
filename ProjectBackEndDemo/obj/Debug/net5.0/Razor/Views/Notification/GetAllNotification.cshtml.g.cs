#pragma checksum "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb22c2c2def25e44ea3d2ab34ffa4866dab72b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_GetAllNotification), @"mvc.1.0.view", @"/Views/Notification/GetAllNotification.cshtml")]
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
#line 1 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\_ViewImports.cshtml"
using ProjectBackEndDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\_ViewImports.cshtml"
using ProjectBackEndDemo.Resource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb22c2c2def25e44ea3d2ab34ffa4866dab72b7d", @"/Views/Notification/GetAllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd52d18e4e212d90e8be51fa2a462b6241a5b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_GetAllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjectBackEndDemo.Models.NotificationVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
  
    ViewData["Title"] = "GetAllNotification";
    Layout = "~/Views/Layouts/MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>GetAllNotification</h1>\r\n\r\n<ul  class=\'list-group\'>\r\n");
#nullable restore
#line 12 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\'list-group-item notification-text\' data-id=\'");
#nullable restore
#line 14 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
                                                      Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'> ");
#nullable restore
#line 14 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
                                                                 Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a class=\'text-primary\'");
            BeginWriteAttribute("href", " href=\'", 370, "\'", 395, 1);
#nullable restore
#line 14 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
WriteAttributeValue("", 377, item.UrlReference, 377, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> View Page </a>  ");
#nullable restore
#line 14 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"
                                                                                                                                                Write(item.time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 15 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Views\Notification\GetAllNotification.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjectBackEndDemo.Models.NotificationVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591