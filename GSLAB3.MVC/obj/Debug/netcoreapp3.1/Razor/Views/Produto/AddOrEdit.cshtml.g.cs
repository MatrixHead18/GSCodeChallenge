#pragma checksum "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3204c6da98334d17ff7ef1c0adbce7f1b192bf53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_AddOrEdit), @"mvc.1.0.view", @"/Views/Produto/AddOrEdit.cshtml")]
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
#line 1 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\_ViewImports.cshtml"
using GSLAB3.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\_ViewImports.cshtml"
using GSLAB3.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3204c6da98334d17ff7ef1c0adbce7f1b192bf53", @"/Views/Produto/AddOrEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7454afd03dbb84af1907d5ce59ce64c3d03969", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_AddOrEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GSLAB3.MVC.Models.mvcProduto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
  
    ViewData["Title"] = "AddOrEdit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-body\">\r\n");
#nullable restore
#line 7 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
   Write(Html.HiddenFor(model => model.IdProduto));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 12 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 17 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.LabelFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.EditorFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Enviar\" class=\"btn btn-success\" />\r\n            <input type=\"reset\" value=\"Limpar Campos\" class=\"btn btn-outline-info\" />\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\GUIZÃO\Desktop\GSLab-Challenge\GSLAB3.MVC\Views\Produto\AddOrEdit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3204c6da98334d17ff7ef1c0adbce7f1b192bf537330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSLAB3.MVC.Models.mvcProduto> Html { get; private set; }
    }
}
#pragma warning restore 1591
