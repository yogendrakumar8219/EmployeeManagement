#pragma checksum "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95ac3828232dfb656e97a87096a4ce5477751bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#line 2 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#line 3 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95ac3828232dfb656e97a87096a4ce5477751bf", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdba5a42a104c51ab5ab187e8603a747815f2979", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 271, true);
            WriteLiteral(@"<h3>An ocured while processing your request. The support team is notified and we are working on the fix</h3>
<h5>Please contact us on 9897505503</h5>
<hr/>
<h3>Exception Details :</h3>
<div class=""alert alert-danger"">
    <h5>Exception Path</h5>
    <hr />
    <p>");
            EndContext();
            BeginContext(272, 21, false);
#line 8 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
            EndContext();
            BeginContext(293, 99, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Message</h5>\r\n    <hr />\r\n    <p>");
            EndContext();
            BeginContext(393, 24, false);
#line 13 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
            EndContext();
            BeginContext(417, 103, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Stack Trace</h5>\r\n    <hr />\r\n    <p>");
            EndContext();
            BeginContext(521, 18, false);
#line 18 "F:\C # PROGRAM\2019\.NET CORE\EmployeeManagement\EmployeeManagement\Views\Shared\Error.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
            EndContext();
            BeginContext(539, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            EndContext();
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
