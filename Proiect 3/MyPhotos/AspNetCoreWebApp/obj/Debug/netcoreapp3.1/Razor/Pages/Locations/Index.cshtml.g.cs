#pragma checksum "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3f4bdad4fe7929e7122ceb2e1744c94f79aa76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreWebApp.Pages.Locations.Pages_Locations_Index), @"mvc.1.0.razor-page", @"/Pages/Locations/Index.cshtml")]
namespace AspNetCoreWebApp.Pages.Locations
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
#line 1 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\_ViewImports.cshtml"
using AspNetCoreWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3f4bdad4fe7929e7122ceb2e1744c94f79aa76", @"/Pages/Locations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b91f49ac917cfe52c788aaf384ee7505cd30c8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Locations_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Locations</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Locations[0].LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Locations[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Photos made\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
         foreach (var item in Model.Locations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size:small\">\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LocationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Photos.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "E:\CURSURI\AN 3\TSP.NET\MyPhotos\AspNetCoreWebApp\Pages\Locations\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreWebApp.Pages.Locations.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCoreWebApp.Pages.Locations.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCoreWebApp.Pages.Locations.IndexModel>)PageContext?.ViewData;
        public AspNetCoreWebApp.Pages.Locations.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591