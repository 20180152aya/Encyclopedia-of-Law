#pragma checksum "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709e34ad7955b2d8dbcb77b45e87c608220ea77b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Reviews), @"mvc.1.0.view", @"/Views/Shared/_Reviews.cshtml")]
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
#line 1 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709e34ad7955b2d8dbcb77b45e87c608220ea77b", @"/Views/Shared/_Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user-male.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
  
    var reviews = _context.Requests.Where(r => r.Rating > 0).ToList();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
     foreach (var item in reviews)
    {
        var id = item.UserId;
        var user = _context.Users.Where(l => l.Id == id).FirstOrDefault();


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"swiper-slide\">\r\n            <div class=\"testimonial-item\">\r\n");
#nullable restore
#line 12 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                 if (user.ProfilePicture != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "709e34ad7955b2d8dbcb77b45e87c608220ea77b5379", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 481, "~/images/", 481, 9, true);
#nullable restore
#line 14 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
AddHtmlAttributeValue("", 490, user.ProfilePicture, 490, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "709e34ad7955b2d8dbcb77b45e87c608220ea77b7266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h3>");
#nullable restore
#line 21 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                               Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h4>User</h4>\r\n                <div class=\"stars\">\r\n");
#nullable restore
#line 24 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                     for (int i = 1; i <= item.Rating; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"bi bi-star-fill text-warning\"></i>\r\n                        <small class=\"text-muted\"></small>\r\n");
#nullable restore
#line 28 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <p>\r\n                    <i class=\"bi bi-quote quote-icon-left\"></i>\r\n                    ");
#nullable restore
#line 32 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"
               Write(item.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i class=\"bi bi-quote quote-icon-right\"></i>\r\n                </p>\r\n            </div>\r\n        </div><!-- End testimonial item -->\r\n");
#nullable restore
#line 37 "D:\Projects\Encyclopedia of laws\Views\Shared\_Reviews.cshtml"

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Encyclopedia_Of_Laws.Data.EncyclopediaOfLawsContext _context { get; private set; }
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
