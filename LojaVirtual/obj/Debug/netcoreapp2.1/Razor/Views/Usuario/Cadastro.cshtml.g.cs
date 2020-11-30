#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325e37949c62caa200b211af097ea47acacd9dba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastro), @"mvc.1.0.view", @"/Views/Usuario/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastro.cshtml", typeof(AspNetCore.Views_Usuario_Cadastro))]
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
#line 1 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 2 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325e37949c62caa200b211af097ea47acacd9dba", @"/Views/Usuario/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b6397a813ab2e3f29c2c4626f1b3aa86fa5744", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Acesso.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario/validacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro de cliente";

#line default
#line hidden
            BeginContext(99, 69, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4>Cadastro de cliente</h4>\r\n\r\n    ");
            EndContext();
            BeginContext(168, 2878, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3943f36e2e85461f8cf845d0ef448bb9", async() => {
                BeginContext(217, 325, true);
                WriteLiteral(@"
        <div class=""row justify-content-center mt-4"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Nome</label>
                <input class=""form-control"" id=""nome"" name=""nome"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 542, "\"", 569, 1);
#line 15 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 550, Model.Cliente.Nome, 550, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(570, 333, true);
                WriteLiteral(@"/>
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-2 text-center mt-2 mt-md-0"">
                <label>CPF</label>
                <input class=""form-control cpf"" id=""cpf"" type=""text"" placeholder=""000.000.000-00"" name=""cpf""
                       style=""text-align: center"" onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 903, "\"", 929, 1);
#line 20 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 911, Model.Cliente.Cpf, 911, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(930, 464, true);
                WriteLiteral(@" />
                <div class=""invalid-feedback text-left"" id=""cpf"">Insira um CPF válido</div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-9 col-sm-8 col-md-8 col-xl-6 text-center"">
                <label>Endereço de Email</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">");
                EndContext();
                BeginContext(1395, 136, true);
                WriteLiteral("@</span>\r\n                    </div>\r\n                    <input class=\"form-control\" id=\"email\" type=\"text\" maxlength=\"35\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                           placeholder=\"", 1531, "\"", 1591, 3);
                WriteAttributeValue("", 1573, "exemplo", 1573, 7, true);
                WriteAttributeValue("", 1580, "@", 1580, 1, true);
                WriteAttributeValue("", 1582, "email.com", 1582, 9, true);
                EndWriteAttribute();
                BeginContext(1592, 84, true);
                WriteLiteral(" style=\"text-align: center\"\r\n                           onchange=\"ValidaCampo(this)\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1676, "\"", 1696, 1);
#line 33 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 1684, Model.Email, 1684, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1697, 552, true);
                WriteLiteral(@" />
                    <div class=""invalid-feedback text-left"" id=""email""></div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-9 col-sm-7 col-md-4 col-xl-3 text-center text-md-left"">
                <label>Senha</label>
                <input class=""form-control senha"" id=""senha"" type=""password"" maxlength=""30""
                       placeholder=""*******"" style=""text-align: center"" name=""senha""
                       onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2249, "\"", 2269, 1);
#line 43 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 2257, Model.Senha, 2257, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2270, 769, true);
                WriteLiteral(@" />
                <div class=""invalid-feedback text-left msg-senha"" id=""senha""></div>
            </div>
            <div class=""col-9 col-sm-7 col-md-4 col-xl-3 text-center text-md-left mt-2 mt-md-0"">
                <label>Confirme sua senha</label>
                <input class=""form-control conf"" id=""confirma"" type=""password"" maxlength=""30""
                       style=""text-align: center"" onchange=""ValidaCampo(this)"" />
                <div class=""invalid-feedback text-left msg-conf"" id=""confirma""></div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-success col-6 col-sm-5 col-md-3"" type=""button"" onclick=""ValidaRegistro()"">Registrar</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3046, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3058, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "365dc0118d7c4a33be89949049caf48e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Acesso.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
