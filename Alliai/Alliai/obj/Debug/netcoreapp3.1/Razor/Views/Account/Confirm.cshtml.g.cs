#pragma checksum "C:\Users\User\Desktop\Homework\Alliai\Alliai\Views\Account\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a051b5a6320e247d9075d3eb38f474f9b56ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Confirm), @"mvc.1.0.view", @"/Views/Account/Confirm.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Homework\Alliai\Alliai\Views\_ViewImports.cshtml"
using Alliai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Homework\Alliai\Alliai\Views\_ViewImports.cshtml"
using Alliai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a051b5a6320e247d9075d3eb38f474f9b56ec5", @"/Views/Account/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c5947fd760809928758381c9ec3bd8a60fb01b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Homework\Alliai\Alliai\Views\Account\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""bg_gray"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-5"">
                <div id=""confirm"">
                    <div class=""icon icon--order-success svg add_bottom_15"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""72"" height=""72"">
                            <g fill=""none"" stroke=""#8EC343"" stroke-width=""2"">
                                <circle cx=""36"" cy=""36"" r=""35"" style=""stroke-dasharray:240px, 240px; stroke-dashoffset: 480px;""></circle>
                                <path d=""M17.417,37.778l9.93,9.909l25.444-25.393"" style=""stroke-dasharray:50px, 50px; stroke-dashoffset: 0px;""></path>
                            </g>
                        </svg>
                    </div>
                    <h2>Order completed!</h2>
                    <p>You will receive a confirmation email soon!</p>
                </div>
            </div>
        </div>
        <!-- /row -->
    </div>
  ");
            WriteLiteral("  <!-- /container -->\r\n\r\n</main>\r\n<!--/main-->\r\n\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    <!-- SPECIFIC CSS -->\r\n    <link href=\"css/checkout.css\" rel=\"stylesheet\">\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
