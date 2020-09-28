#pragma checksum "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0655b276cf7b2e04125791a90d10d0dc7ca50fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Persons), @"mvc.1.0.view", @"/Views/Home/Persons.cshtml")]
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
#line 1 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\_ViewImports.cshtml"
using TestingNetNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\_ViewImports.cshtml"
using TestingNetNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0655b276cf7b2e04125791a90d10d0dc7ca50fd", @"/Views/Home/Persons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2bd435182ba9a1e02efbdac9b340bc0170895b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Persons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonalDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
  
    ViewData["Title"] = "Person collection in our list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Persons</h1>\n");
#nullable restore
#line 7 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
Write(Html.ActionLink("Add Person", "CreatePerson", "Home", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table border=""1"" class=""table table-bordered"">
    <thead>
        <tr>
            <th>Personal Detail Id</th>
            <th>Name</th>
            <th>Address</th>
            <th>Occupation</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
         foreach(var person in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 22 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
           Write(person.PersonalDetailId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 23 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
           Write(person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
           Write(person.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
           Write(person.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                ");
#nullable restore
#line 27 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
           Write(Html.ActionLink("Details", "PersonalDetails", "Home", new { personDetailId = person.PersonalDetailId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 28 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
                   Write(Html.ActionLink("Edit", "EditPersonalDetail", "Home", new { personDetailId = person.PersonalDetailId }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 29 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
                   Write(Html.ActionLink("Delete", "DeletePerson", "Home", new { personDetailId = person.PersonalDetailId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 44 "D:\C#\CRUD\FirstMVCApp\FirstMVCApp\Views\Home\Persons.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonalDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
