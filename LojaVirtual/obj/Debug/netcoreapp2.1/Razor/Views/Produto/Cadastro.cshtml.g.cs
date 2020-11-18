#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919b240272aeefec1112219bc4ff1d1083bc6136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastro), @"mvc.1.0.view", @"/Views/Produto/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Cadastro.cshtml", typeof(AspNetCore.Views_Produto_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919b240272aeefec1112219bc4ff1d1083bc6136", @"/Views/Produto/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b6397a813ab2e3f29c2c4626f1b3aa86fa5744", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Produto/validacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro de produto";

#line default
#line hidden
            BeginContext(100, 69, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4>Cadastro de produto</h4>\r\n\r\n    ");
            EndContext();
            BeginContext(169, 6246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92271acd93424d138c8b84782318072b", async() => {
                BeginContext(218, 625, true);
                WriteLiteral(@"
        <div class=""row justify-content-center text-center text-md-left mt-4"">
            <div class=""col-10 col-md-6 col-xl-5"">
                <label>Nome</label>
                <input id=""nome"" type=""text"" class=""form-control"" maxlength=""30"" onchange=""ValidaCampo(this)"" />
                <div id=""nome"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left mt-4 mt-md-0"">
                <label>Categoria</label>
                <select id=""categoria"" class=""custom-select form-control"" onchange=""ValidaCampo(this)"">
                    ");
                EndContext();
                BeginContext(843, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd000bb3136747f0be184338806a03b7", async() => {
                    BeginContext(860, 22, true);
                    WriteLiteral("Selecione uma opção...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(891, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml"
                     if (ViewBag.Categorias.Count > 0)
                    {
                        foreach (var item in ViewBag.Categorias)
                        {

#line default
#line hidden
                BeginContext(1065, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1093, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b746313cb5e47e099807aea56a08778", async() => {
                    BeginContext(1120, 10, false);
#line 25 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml"
                                                 Write(item.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 25 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml"
                               WriteLiteral(item.Key);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1139, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Cadastro.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1191, 5217, true);
                WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-10 col-md-6 col-xl-5 text-center text-md-left"">
                <label>Descrição</label>
                <textarea id=""descricao"" class=""form-control"" maxlength=""150"" onchange=""ValidaCampo(this)""></textarea>
                <div id=""descricao"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left mt-4 mt-md-0"">
                <label>Valor</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">R$</div>
                    </div>
                    <input id=""valor"" type=""text"" class=""form-control real"" style=""text-align: center""
                           placeholder=""0,00"" onchange=""ValidaValor(this)"" />
                    <div id=""valor"" class=""invalid-feedback msg-valor""></div>
              ");
                WriteLiteral(@"  </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left mt-4 mt-md-0"">
                <label>Qtd.estoque</label>
                <input id=""estoque"" type=""text"" class=""form-control quantidade""
                       placeholder=""000"" style=""text-align: center"" onchange=""ValidaValor(this)"" />
                <div id=""estoque"" class=""invalid-feedback msg-valor""></div>
            </div>
        </div>
        <div class=""row mt-4 justify-content-center"">
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left"">
                <label>Fabricante</label>
                <input id=""fabricante"" type=""text"" class=""form-control"" maxlength=""25"" onchange=""ValidaCampo(this)"" />
                <div id=""fabricante"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left mt-3 mt-md-0"">
                <label>Modelo</label>
                <input id=""modelo"" type=""text"" class=""form-control"" m");
                WriteLiteral(@"axlength=""25"" onchange=""ValidaCampo(this)"" />
                <div id=""modelo"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left mt-3 mt-md-0"">
                <label>Cor</label>
                <input id=""cor"" type=""text"" class=""form-control"" maxlength=""20"" onchange=""ValidaCampo(this)"" />
                <div id=""cor"" class=""invalid-feedback""></div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-4 col-md-3 col-xl-2 text-left"">
                <label>Largura</label>
                <div class=""input-group"">
                    <input id=""largura"" type=""text"" class=""form-control cm"" style=""text-align: center""
                           placeholder=""0"" onchange=""ValidaLargura()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">cm</div>
                    </div>
                    <div id=""l");
                WriteLiteral(@"argura"" class=""invalid-feedback msg-largura""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left"">
                <label>Altura</label>
                <div class=""input-group"">
                    <input id=""altura"" type=""text"" class=""form-control cm"" style=""text-align: center""
                           placeholder=""0"" onchange=""ValidaAltura()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">cm</div>
                    </div>
                    <div id=""altura"" class=""invalid-feedback msg-altura""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left"">
                <label>Comprimento</label>
                <div class=""input-group"">
                    <input id=""comprimento"" type=""text"" class=""form-control cm"" style=""text-align: center""
                           placeholder=""0"" onchange=""ValidaComprimento()"" />
  ");
                WriteLiteral(@"                  <div class=""input-group-prepend"">
                        <div class=""input-group-text"">cm</div>
                    </div>
                    <div id=""comprimento"" class=""invalid-feedback msg-comprimento""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 ml-xl-4 text-lg-left mt-3 mt-md-0 mt-xl-0"">
                <label>Peso</label>
                <div class=""input-group"">
                    <input id=""peso"" type=""text"" class=""form-control kg"" style=""text-align: center""
                           placeholder=""0,00"" onchange=""ValidaPeso()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">Kg</div>
                    </div>
                    <div id=""cor"" class=""invalid-feedback msg-peso""></div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-success col-6 col-");
                WriteLiteral("sm-5 col-md-3\" type=\"button\" onclick=\"ValidaRegistro(1)\">Registrar</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6415, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(6427, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba8413c723844b2b6f7914bb326e571", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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