#pragma checksum "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5681ba5be77080a6333a31faf079ba4d37f6f1b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
#line 1 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\_ViewImports.cshtml"
using SampleMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\_ViewImports.cshtml"
using SampleMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5681ba5be77080a6333a31faf079ba4d37f6f1b7", @"/Views/Book/GetAllBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5d05113245796ca7638ef41268cf3ab57e8cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
  
    ViewData["Title"] = "GetAllBooks";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"display-4\">All Books</h3>\r\n    <div class=\" row\">\r\n");
#nullable restore
#line 11 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg""></svg>
                    <div class=""card-body"">
                        <p class=""card-text"">");
#nullable restore
#line 17 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
                                        Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
                                        Write(book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"d-flex justify-content-between align-items-center\">\r\n                            <div class=\"btn-group\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 819, "\"", 848, 2);
            WriteAttributeValue("", 826, "/book/getbook/", 826, 14, true);
#nullable restore
#line 21 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
WriteAttributeValue("", 840, book.Id, 840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">View details</a>\r\n                            </div>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 23 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
                                                 Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Mahesh Dasari\Desktop\project\SampleMVC\SampleMVC\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591