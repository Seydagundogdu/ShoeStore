#pragma checksum "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3418ce2b3940ed6548f4a32008fc1d3efcfc727f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
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
#line 7 "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\_ViewImports.cshtml"
using shoestore.entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3418ce2b3940ed6548f4a32008fc1d3efcfc727f", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab3a40edf0aea072491ab87c766b9ce1dce789a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/product/list\" class=\"list-group-item list-group-item-action\">Tüm Koleksiyon</a>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\Shared\Components\Categories\Default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 203, "\"", 244, 2);
            WriteAttributeValue("", 210, "/product/list/", 210, 14, true);
#nullable restore
#line 8 "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 224, category.CategoryId, 224, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 8 "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\Shared\Components\Categories\Default.cshtml"
                                                                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 9 "C:\Users\acer\Desktop\shoestore\shoestore.webui\Views\Shared\Components\Categories\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
