#pragma checksum "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f7ab4e9bc524b556a1ba4679b4de2d30611b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload__Index), @"mvc.1.0.view", @"/Views/Upload_/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload_/Index.cshtml", typeof(AspNetCore.Views_Upload__Index))]
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
#line 1 "C:\Users\DELL\Desktop\upload_web\Views\_ViewImports.cshtml"
using upload_web;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\upload_web\Views\_ViewImports.cshtml"
using upload_web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f7ab4e9bc524b556a1ba4679b4de2d30611b6a", @"/Views/Upload_/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30cdb5c3dd7518695981b4f8e61eababa76d586d", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<upload_web.Models.FileUpload>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(47, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f7ab4e9bc524b556a1ba4679b4de2d30611b6a3305", async() => {
                BeginContext(53, 139, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Upload File and Save In Binary Format in Asp.net Core 2</title>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(201, 1629, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8f7ab4e9bc524b556a1ba4679b4de2d30611b6a4635", async() => {
                BeginContext(207, 13, true);
                WriteLiteral("\r\n    <div>\r\n");
                EndContext();
#line 11 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
         using (Html.BeginForm("Index", "Upload", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
                BeginContext(339, 371, true);
                WriteLiteral(@"<table>
                <tr>
                    <td>File Upload:</td>
                    <td>
                        <input type=""file"" id=""File_Upload"" name=""File"" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>File Name:</td>
                    <td>
                        ");
                EndContext();
                BeginContext(711, 93, false);
#line 23 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
                   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(804, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(831, 82, false);
#line 24 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(913, 512, true);
                WriteLiteral(@"
                        <br />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <br />
                        <input type=""submit"" value=""Upload"" class=""btn-default"" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
");
                EndContext();
#line 42 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
                     if (!string.IsNullOrEmpty(@ViewBag.Image))
                    {

#line default
#line hidden
                BeginContext(1513, 112, true);
                WriteLiteral("                        <td>Uploaded Image:</td>\r\n                        <td>\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1625, "\"", 1645, 1);
#line 46 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
WriteAttributeValue("", 1631, ViewBag.Image, 1631, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1646, 86, true);
                WriteLiteral(" width=\"250px\" height=\"200px\" alt=\"Alternate Text\" />\r\n                        </td>\r\n");
                EndContext();
#line 48 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1755, 45, true);
                WriteLiteral("                </tr>\r\n            </table>\r\n");
                EndContext();
#line 51 "C:\Users\DELL\Desktop\upload_web\Views\Upload_\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1811, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1830, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<upload_web.Models.FileUpload> Html { get; private set; }
    }
}
#pragma warning restore 1591