#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2029cd4452ae8f974e5ac2aa1611f4bec019d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Imagem), @"mvc.1.0.view", @"/Views/Produto/Imagem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Imagem.cshtml", typeof(AspNetCore.Views_Produto_Imagem))]
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
#line 4 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Sessions;

#line default
#line hidden
#line 5 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Validations;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2029cd4452ae8f974e5ac2aa1611f4bec019d78", @"/Views/Produto/Imagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Imagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Produto/imagem.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
  
    ViewData["Title"] = "Imagem de produto";

#line default
#line hidden
            BeginContext(98, 296, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h4>Imagem de produto</h4>

    <div class=""row justify-content-center text-center text-md-left mt-4"">
        <div class=""col-10 col-md-6 col-xl-4"">
            <label>Nome</label>
            <input id=""nome"" type=""text"" class=""form-control"" maxlength=""30""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 394, "\"", 413, 1);
#line 13 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
WriteAttributeValue("", 402, Model.Nome, 402, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(414, 223, true);
            WriteLiteral(" readonly />\r\n        </div>\r\n        <div class=\"col-8 col-md-4 col-xl-3 text-center text-md-left\">\r\n            <label>Fabricante</label>\r\n            <input id=\"fabricante\" type=\"text\" class=\"form-control\" maxlength=\"25\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 637, "\"", 662, 1);
#line 17 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
WriteAttributeValue("", 645, Model.Fabricante, 645, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(663, 228, true);
            WriteLiteral(" readonly />\r\n        </div>\r\n        <div class=\"col-8 col-md-4 col-xl-3 text-center text-md-left mt-3 mt-md-0\">\r\n            <label>Modelo</label>\r\n            <input id=\"modelo\" type=\"text\" class=\"form-control\" maxlength=\"25\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 891, "\"", 912, 1);
#line 21 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
WriteAttributeValue("", 899, Model.Modelo, 899, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(913, 787, true);
            WriteLiteral(@" readonly />
        </div>
    </div>

    <div class=""row justify-content-center text-left mt-5"">
        <div class=""col-4"">
            <div class=""input-group"">
                <div class=""custom-file"">
                    <input type=""file"" class=""custom-file-input"" onchange=""CarregaImagem()"">
                    <label data-browse=""Selecionar"" class=""custom-file-label"">Escolha o arquivo de imagem</label>
                </div>
            </div>
        </div>
    </div>

    <div class=""d-none"" id=""form-imagem"">
        <div class=""row mt-4"">
            <div class=""col"">
                <img id=""imagem"" src="""" width=""150"" height=""150"">
                <input type=""hidden"" id=""caminho"" value="""" />
                <input type=""hidden"" id=""id-produto""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1700, "\"", 1724, 1);
#line 41 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
WriteAttributeValue("", 1708, Model.IdProduto, 1708, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1725, 470, true);
            WriteLiteral(@" />
            </div>
        </div>
        <div class=""row justify-content-center mt-1 mb-3"">
            <button class=""btn btn-sm btn-outline-success"" id=""salvar"" type=""button"" onclick=""SalvaImagem()""><i class=""fa fa-check""></i></button>
            <button class=""btn btn-sm btn-outline-danger ml-2"" id=""remover"" type=""button"" onclick=""DescartaImagem()""><i class=""fa fa-trash""></i></button>
        </div>
    </div>

    <div id=""lista-imagem"">
        ");
            EndContext();
            BeginContext(2196, 49, false);
#line 51 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
   Write(await Html.PartialAsync("_Imagens", Model.Imagem));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 130, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"row justify-content-center mt-5 mb-3\">\r\n        <a class=\"btn btn-success col-6 col-sm-5 col-md-3\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2375, "\"", 2413, 1);
#line 55 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Imagem.cshtml"
WriteAttributeValue("", 2382, Url.Action("Lista", "Produto"), 2382, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2414, 911, true);
            WriteLiteral(@">Finalizar</a>
    </div>
</div>

<div class=""modal fade"" id=""remove-imagem"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação de exclusão</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-left"">
                Remover imagem de produto?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"" onclick=""RemoveImagem()"">Remover</button>
                <input type=""hidden"" id=""caminho-remover"" />
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(3325, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25d7a7c872c4aa28beb63d1cadb9142", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
