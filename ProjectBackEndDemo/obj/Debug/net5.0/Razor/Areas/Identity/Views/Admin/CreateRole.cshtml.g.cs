#pragma checksum "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Identity\Views\Admin\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e3a3357d7afef8b6672bdfe8ff62878f0288b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Admin_CreateRole), @"mvc.1.0.view", @"/Areas/Identity/Views/Admin/CreateRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e3a3357d7afef8b6672bdfe8ff62878f0288b2a", @"/Areas/Identity/Views/Admin/CreateRole.cshtml")]
    public class Areas_Identity_Views_Admin_CreateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Garduation Project\ProjectBackEndDemo\ProjectBackEndDemo\Areas\Identity\Views\Admin\CreateRole.cshtml"
  
    ViewData["Title"] = "CreateRole";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateRole</h1>\r\n\r\n<form asp-area=\"Identity\" asp-controller=\"Account\" asp-action=\"CreateRole\" method=\"post\">\r\n    <label name=\"rolename\"> Role Name </label>\r\n    <input type=\"text\" name=\"rolename\" />\r\n    <input type=\"submit\"");
            BeginWriteAttribute("name", " name=\"", 279, "\"", 286, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Create Role\" />\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591