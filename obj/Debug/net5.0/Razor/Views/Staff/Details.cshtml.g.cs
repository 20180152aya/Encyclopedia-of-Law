#pragma checksum "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9896b30ec34f8707983e527c4dc543f0e30a6e0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Details), @"mvc.1.0.view", @"/Views/Staff/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9896b30ec34f8707983e527c4dc543f0e30a6e0b", @"/Views/Staff/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encyclopedia_Of_Laws.Models.Subjectsمواد>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubjectPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
  
    ViewData["Title"] = "Details";
 //   Layout = "~/Views/Shared/_StaffLayout.cshtml";
    ViewData["Action"] = "Laws_Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .row {
        text-align: right;
        font-size: 23px;
    }

    dt {
        width: 115px;
    }
</style>
<h1 style=""text-align:right""> تـفـاصيـل الماده</h1>
<hr />
<div class=""details_container"">
    <div>

        <dl class=""row"">
            <dd class=""col-sm-10"">
                ");
#nullable restore
#line 25 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
           Write(Html.DisplayFor(model => model.رقمالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                : ");
#nullable restore
#line 28 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
             Write(Html.DisplayNameFor(model => model.رقمالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
           Write(Html.DisplayFor(model => model.محتوىالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                : ");
#nullable restore
#line 34 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
             Write(Html.DisplayNameFor(model => model.محتوىالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
           Write(Html.DisplayFor(model => model.حالهالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                : ");
#nullable restore
#line 40 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
             Write(Html.DisplayNameFor(model => model.حالهالماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
           Write(Html.DisplayFor(model => model.التعديلالسابقللماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                : ");
#nullable restore
#line 46 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
             Write(Html.DisplayNameFor(model => model.التعديلالسابقللماده));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
           Write(Html.DisplayFor(model => model.سنهالتعديلالسابق));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                : ");
#nullable restore
#line 52 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
             Write(Html.DisplayNameFor(model => model.سنهالتعديلالسابق));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n        </dl>\r\n    </div>\r\n    <div style=\"font-size:22px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9896b30ec34f8707983e527c4dc543f0e30a6e0b8253", async() => {
                WriteLiteral("تعديل");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\Projects\Encyclopedia of laws\Views\Staff\Details.cshtml"
                                         WriteLiteral(Model.IdSubjects);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9896b30ec34f8707983e527c4dc543f0e30a6e0b10485", async() => {
                WriteLiteral("الرجوع إلي المواد");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encyclopedia_Of_Laws.Models.Subjectsمواد> Html { get; private set; }
    }
}
#pragma warning restore 1591
