#pragma checksum "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6402f7e34da3114b18e533ca275763ebc0313c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Topic), @"mvc.1.0.view", @"/Views/Forum/Topic.cshtml")]
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
#line 1 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\_ViewImports.cshtml"
using KSPForums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\_ViewImports.cshtml"
using KSPForums.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\_ViewImports.cshtml"
using KSPForums.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6402f7e34da3114b18e533ca275763ebc0313c5", @"/Views/Forum/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4e69b255a1ccb9bbe20d7e56274aec7bf057f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KSPForums.Models.Forum.ForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
  
    ViewData["Title"] = "Topic";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome to the ");
#nullable restore
#line 6 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
              Write(Model.Forum.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Forum!</h1>\r\n\r\n");
#nullable restore
#line 8 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
 if(Model.Posts.Any()){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\r\n        <tbody>\r\n");
#nullable restore
#line 11 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
             foreach (var post in Model.Posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 15 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
               Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 18 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
               Write(post.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 21 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
               Write(post.DatePosted);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
               Write(post.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 28 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 31 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"noPosts\">\r\n        <h3>\r\n            It looks like there are no ");
#nullable restore
#line 36 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
                                  Write(Model.Forum.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" posts yet. <br/>\r\n            Why not\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6402f7e34da3114b18e533ca275763ebc0313c57177", async() => {
                WriteLiteral("\r\n                <span>Create</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
                                                           WriteLiteral(Model.Forum.Id);

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
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n");
#nullable restore
#line 43 "G:\Farhan(Vacation)\NewWorld\Core(Prac)\Forum\KSPForums\KSPForums\Views\Forum\Topic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KSPForums.Models.Forum.ForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
