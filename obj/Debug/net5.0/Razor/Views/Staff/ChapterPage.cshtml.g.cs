#pragma checksum "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4356d86534dd96adcb314665efcc9bc15d72568d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_ChapterPage), @"mvc.1.0.view", @"/Views/Staff/ChapterPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4356d86534dd96adcb314665efcc9bc15d72568d", @"/Views/Staff/ChapterPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_ChapterPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encyclopedia_Of_Laws.ViewModels.AllChaptersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ChapterController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add_Contents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit_Chapter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
  
    ViewData["Title"] = "ChapterPage";
    //   Layout = "~/Views/Shared/_StaffLayout.cshtml";
    ViewData["Action"] = "Create_Chapter";
    ViewData["Possible_Search"] = "أسم الفصل";
    int i = 1;
    int k = 1;
    string blabla;

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4356d86534dd96adcb314665efcc9bc15d72568d6458", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4356d86534dd96adcb314665efcc9bc15d72568d7636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"


<div class=""card"">
    <div class=""card-body"" style=""padding: 20px;"">

        <!-- Table with hoverable rows -->
        <table class=""table table-hover"" style=""width: 100%;"">
                <thead>
                    <tr>
                        <th>العمليات</th>
                        <th>اسم الفصل</th>
                        <th>رقم الفصل</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                     foreach (var value in Model.chapters)
                    {
                        k = 1;
                        i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1067, "\"", 1107, 3);
            WriteAttributeValue("", 1077, "showHideRow(", 1077, 12, true);
#nullable restore
#line 35 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
WriteAttributeValue("", 1089, value.IdChapter, 1089, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1105, ");", 1105, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"table-rows\">\r\n                            <td class=\"processes\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4356d86534dd96adcb314665efcc9bc15d72568d10210", async() => {
                WriteLiteral("\r\n                                    إضاقة نقاط\r\n                                    <i class=\"bi bi-plus\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                                                       WriteLiteral(value.IdChapter);

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
            WriteLiteral("\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4356d86534dd96adcb314665efcc9bc15d72568d12667", async() => {
                WriteLiteral("\r\n                                    تعديل\r\n                                    <i class=\"bi bi-pencil\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                                                       WriteLiteral(value.IdChapter);

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
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"first-row\">");
#nullable restore
#line 48 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                  Write(value.اسمالفصل);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 49 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                 foreach (Chapter2 mm in Model.chapter2)
                                {
                                    blabla = "hidden_row" + i + "_" + value.IdChapter;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                     if (mm.IdChapter == value.IdChapter)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("id", " id=", 2223, "", 2234, 1);
#nullable restore
#line 55 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
WriteAttributeValue("", 2227, blabla, 2227, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hidden_row\">\r\n\r\n                                            <a>");
#nullable restore
#line 57 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                          Write(mm.اسمالنقطه);

#line default
#line hidden
#nullable disable
            WriteLiteral("  __|</a>\r\n\r\n");
#nullable restore
#line 59 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                             foreach (Chapter3 mo in Model.chapter3)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                 if (mo.IdCh2 == mm.IdCh2)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <br />\r\n                                                    <a> ");
#nullable restore
#line 64 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                   Write(mo.محتويالنقطه);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ____| &nbsp &nbsp &nbsp</a>\r\n");
#nullable restore
#line 65 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n");
#nullable restore
#line 68 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                                     

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td style=\"text-align:right\">\r\n                                ");
#nullable restore
#line 74 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                           Write(value.رقمالفصل);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 78 "D:\Projects\Encyclopedia of laws\Views\Staff\ChapterPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n        </table>\r\n        <!-- End Table with hoverable rows -->\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encyclopedia_Of_Laws.ViewModels.AllChaptersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
