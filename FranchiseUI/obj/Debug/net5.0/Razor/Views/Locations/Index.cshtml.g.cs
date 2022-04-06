#pragma checksum "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842af15663ea3475ef3cdf4df457444beb4b0152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Index), @"mvc.1.0.view", @"/Views/Locations/Index.cshtml")]
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
#line 1 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/_ViewImports.cshtml"
using FranchiseUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/_ViewImports.cshtml"
using FranchiseUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842af15663ea3475ef3cdf4df457444beb4b0152", @"/Views/Locations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f135ac271347a3a753e75fb2642cf52e83c4cd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ParserLibrary.ITrackable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""//cdn.datatables.net/1.10.25/css/jquery.dataTables.min.css"" />
<link href=""/css/site.css"" rel=""stylesheet"" />

<div class=""wrapper"">
    <section class=""container"" id=""locations"">

        <article id=""content"">
            <header>
                <h2>Data Table</h2>
            </header>
            <p>
                ");
#nullable restore
#line 18 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
           Write(Html.ActionLink("Create", "Create", "Locations", null, new { @class = "btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 19 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
           Write(Html.ActionLink("Cancel", "Index", "Home", null, null, "promo", new { @class = "btn" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <table class=""table locations"" id=""LocationsTable"">

                <thead>
                    <tr>
                        <th>
                            Id
                        </th>
                        <th>
                            Latitude
                        </th>
                        <th>
                            Longitude
                        </th>
                        <th>
                            Location Name
                        </th>

");
            WriteLiteral("\n                    </tr>\n                </thead>\n\n                <tbody>\n");
#nullable restore
#line 44 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 48 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 51 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GeoPoint.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 54 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GeoPoint.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 57 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n");
            WriteLiteral("                        </tr>\n");
#nullable restore
#line 64 "/Users/lynda/Desktop/repo/Franchise/FranchiseUI/Views/Locations/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </article>\n\n    </section>\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    <script src=\"//cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js\"></script>\n    <script>$(document).ready(function () {\n            $(\'#LocationsTable\').DataTable();\n        });</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ParserLibrary.ITrackable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
