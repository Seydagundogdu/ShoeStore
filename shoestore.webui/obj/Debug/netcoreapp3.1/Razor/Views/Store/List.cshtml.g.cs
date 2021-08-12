#pragma checksum "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7efc45240e0bb11c6dc6cf41bef864f3557a693a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_List), @"mvc.1.0.view", @"/Views/Store/List.cshtml")]
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
#line 7 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\_ViewImports.cshtml"
using shoestore.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\_ViewImports.cshtml"
using shoestore.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\_ViewImports.cshtml"
using shoestore.webui.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efc45240e0bb11c6dc6cf41bef864f3557a693a", @"/Views/Store/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6899d8632815a010ad397d88e8e8b36bed403be7", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 5 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
               Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 14 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 20 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                             if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 852, "\"", 916, 2);
            WriteAttributeValue("", 860, "page-item", 860, 9, true);
#nullable restore
#line 24 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
WriteAttributeValue(" ", 869, Model.PageInfo.CurrentPage==i+1?"active":"", 870, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 1004, 2);
            WriteAttributeValue("", 983, "/products?page=", 983, 15, true);
#nullable restore
#line 25 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
WriteAttributeValue("", 998, i+1, 998, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 26 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 29 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1268, "\"", 1332, 2);
            WriteAttributeValue("", 1276, "page-item", 1276, 9, true);
#nullable restore
#line 32 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
WriteAttributeValue(" ", 1285, Model.PageInfo.CurrentPage==i+1?"active":"", 1286, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1392, "\"", 1452, 4);
            WriteAttributeValue("", 1399, "/products/", 1399, 10, true);
#nullable restore
#line 33 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
WriteAttributeValue("", 1409, Model.PageInfo.CurrentCategory, 1409, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1440, "?page=", 1440, 6, true);
#nullable restore
#line 33 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
WriteAttributeValue("", 1446, i+1, 1446, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 34 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 37 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\acer\Documents\GitHub\ShoeStore\shoestore.webui\Views\Store\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""
    integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo""
    crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""
    integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6""
    crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
