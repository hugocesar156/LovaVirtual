#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06ab4b171f5eef30cd9bd9e03ad4eba3e538a1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Edicao), @"mvc.1.0.view", @"/Views/Produto/Edicao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Edicao.cshtml", typeof(AspNetCore.Views_Produto_Edicao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ab4b171f5eef30cd9bd9e03ad4eba3e538a1fb", @"/Views/Produto/Edicao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Edicao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("descricao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("ValidaCampo(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Produto/validacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Produto/edicao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
  
    ViewData["Title"] = "Edição de produto";

#line default
#line hidden
            BeginContext(98, 79, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4 id=\"titulo\">Edição de produto</h4>\r\n\r\n    ");
            EndContext();
            BeginContext(177, 7083, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f49e5a1e27494deb92f20d0b2f1ebcaa", async() => {
                BeginContext(226, 46, true);
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"id-produto\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 272, "\"", 296, 1);
#line 11 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 280, Model.IdProduto, 280, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(297, 254, true);
                WriteLiteral(" />\r\n        <div class=\"row justify-content-center text-center text-md-left mt-4\">\r\n            <div class=\"col-10 col-md-6 col-xl-5\">\r\n                <label>Nome</label>\r\n                <input id=\"nome\" type=\"text\" class=\"form-control\" maxlength=\"30\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 551, "\"", 570, 1);
#line 15 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 559, Model.Nome, 559, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(571, 374, true);
                WriteLiteral(@" onchange=""ValidaCampo(this)"" />
                <div id=""nome"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left mt-4 mt-md-0"">
                <label>Categoria</label>
                <select id=""categoria"" class=""custom-select form-control"" onchange=""ValidaCampo(this)"">
                    ");
                EndContext();
                BeginContext(945, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00136a359a9c45ce94bfd0d5a5419788", async() => {
                    BeginContext(962, 22, true);
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
                BeginContext(993, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                     foreach (var item in ViewBag.Categorias)
                    {
                        if (item.Key == Model.IdCategoria)
                        {

#line default
#line hidden
                BeginContext(1168, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1196, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "292304fdc1354a02b03cac0d87928b90", async() => {
                    BeginContext(1232, 10, false);
#line 26 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                                                          Write(item.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 26 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                               WriteLiteral(item.Key);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1251, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1337, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1365, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdcf97dc399243958f714b9b941d92c0", async() => {
                    BeginContext(1392, 10, false);
#line 30 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                                                 Write(item.Value);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 30 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
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
                BeginContext(1411, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1463, 253, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n        <div class=\"row justify-content-center mt-4\">\r\n            <div class=\"col-10 col-md-6 col-xl-4 text-center text-md-left\">\r\n                <label>Descrição</label>\r\n                ");
                EndContext();
                BeginContext(1716, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67646fd5523943899990955cc2a3f938", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 39 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Descricao);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1838, 542, true);
                WriteLiteral(@"
                <div id=""descricao"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left mt-4 mt-md-0"">
                <label>Valor</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">R$</div>
                    </div>
                    <input id=""valor"" type=""text"" class=""form-control real"" style=""text-align: center""
                           placeholder=""0,00""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2380, "\"", 2415, 1);
#line 49 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 2388, Model.Valor.ToString("N2"), 2388, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2416, 423, true);
                WriteLiteral(@" onchange=""ValidaValor(this)"" />
                    <div id=""valor"" class=""invalid-feedback msg-valor""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left mt-4 mt-md-0"">
                <label>Qtd.estoque</label>
                <input id=""estoque"" type=""text"" class=""form-control quantidade""
                       placeholder=""000"" style=""text-align: center""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2839, "\"", 2861, 1);
#line 56 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 2847, Model.Estoque, 2847, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2862, 407, true);
                WriteLiteral(@" onchange=""ValidaValor(this)"" />
                <div id=""estoque"" class=""invalid-feedback msg-valor""></div>
            </div>
        </div>
        <div class=""row mt-4 justify-content-center"">
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left"">
                <label>Fabricante</label>
                <input id=""fabricante"" type=""text"" class=""form-control"" maxlength=""25""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3269, "\"", 3294, 1);
#line 63 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 3277, Model.Fabricante, 3277, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3295, 334, true);
                WriteLiteral(@" onchange=""ValidaCampo(this)"" />
                <div id=""fabricante"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-3 text-center text-md-left mt-3 mt-md-0"">
                <label>Modelo</label>
                <input id=""modelo"" type=""text"" class=""form-control"" maxlength=""25""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3629, "\"", 3650, 1);
#line 68 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 3637, Model.Modelo, 3637, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3651, 324, true);
                WriteLiteral(@" onchange=""ValidaCampo(this)"" />
                <div id=""modelo"" class=""invalid-feedback""></div>
            </div>
            <div class=""col-8 col-md-4 col-xl-2 text-center text-md-left mt-3 mt-md-0"">
                <label>Cor</label>
                <input id=""cor"" type=""text"" class=""form-control"" maxlength=""20""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3975, "\"", 3993, 1);
#line 73 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 3983, Model.Cor, 3983, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3994, 478, true);
                WriteLiteral(@" onchange=""ValidaCampo(this)"" />
                <div id=""cor"" class=""invalid-feedback""></div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-4 col-md-3 col-xl-2 text-left"">
                <label>Largura</label>
                <div class=""input-group"">
                    <input id=""largura"" type=""text"" class=""form-control cm"" style=""text-align: center""
                           placeholder=""0""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4472, "\"", 4494, 1);
#line 82 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 4480, Model.Largura, 4480, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4495, 594, true);
                WriteLiteral(@" onchange=""ValidaLargura()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">cm</div>
                    </div>
                    <div id=""largura"" class=""invalid-feedback msg-largura""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-left"">
                <label>Altura</label>
                <div class=""input-group"">
                    <input id=""altura"" type=""text"" class=""form-control cm"" style=""text-align: center""
                           placeholder=""0""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5089, "\"", 5110, 1);
#line 93 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 5097, Model.Altura, 5097, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5111, 601, true);
                WriteLiteral(@" onchange=""ValidaAltura()"" />
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
                           placeholder=""0""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5712, "\"", 5738, 1);
#line 104 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 5720, Model.Comprimento, 5720, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5739, 629, true);
                WriteLiteral(@" onchange=""ValidaComprimento()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">cm</div>
                    </div>
                    <div id=""comprimento"" class=""invalid-feedback msg-comprimento""></div>
                </div>
            </div>
            <div class=""col-4 col-md-3 col-xl-2 text-lg-left mt-3 mt-md-0 mt-xl-0"">
                <label>Peso</label>
                <div class=""input-group"">
                    <input id=""peso"" type=""text"" class=""form-control kg"" style=""text-align: center""
                           placeholder=""0,00""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6368, "\"", 6402, 1);
#line 115 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
WriteAttributeValue("", 6376, Model.Peso.ToString("N2"), 6376, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6403, 820, true);
                WriteLiteral(@" onchange=""ValidaPeso()"" />
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">Kg</div>
                    </div>
                    <div id=""cor"" class=""invalid-feedback msg-peso""></div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-9"">
                <input type=""hidden"" id=""dimensao"" />
                <div id=""dimensao"" class=""invalid-feedback msg-dimensao""></div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-outline-success col-6 col-sm-5 col-md-3"" type=""button"" onclick=""ValidaEdicao()"">
                Salvar
            </button>
        </div>
        ");
                EndContext();
                BeginContext(7224, 23, false);
#line 134 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Produto\Edicao.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(7247, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7260, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(7272, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c592c71ec47b490aaae478c2b8800e8d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7324, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7326, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a769c7c983a642eeb44abc05bb5de237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7375, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7377, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95fe9d8fe02947198a2e8c0f15f875b5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
