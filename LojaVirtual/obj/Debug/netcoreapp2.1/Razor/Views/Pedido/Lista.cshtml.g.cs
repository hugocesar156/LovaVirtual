#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c701bba0e3a97ef7734002638df624cf533aab46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Lista), @"mvc.1.0.view", @"/Views/Pedido/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Lista.cshtml", typeof(AspNetCore.Views_Pedido_Lista))]
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
#line 2 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
using LojaVirtual.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c701bba0e3a97ef7734002638df624cf533aab46", @"/Views/Pedido/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b6397a813ab2e3f29c2c4626f1b3aa86fa5744", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<LojaVirtual.Models.Venda.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
  
    ViewData["Title"] = "Pedidos";

#line default
#line hidden
            BeginContext(130, 383, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h4>Lista de pedidos</h4>

    <div class=""row mt-3 text-right"">
        <div class=""col-9 text-left"">
            <small>
                <strong>
                    <label>Registros por página:</label>
                </strong>
            </small>
            <select class=""ml-2"" id=""quantidade"" onchange=""Pesquisa()"">
                ");
            EndContext();
            BeginContext(513, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13a1a70f0b8348d39fb59945e0f9a617", async() => {
                BeginContext(541, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(552, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(570, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc09d7052e2640d2b7ddcebde47b7817", async() => {
                BeginContext(589, 2, true);
                WriteLiteral("25");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(600, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(618, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f18e54baa945829894c129bca02eb2", async() => {
                BeginContext(637, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(666, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67b9d27452e4c97b198719d755e15cc", async() => {
                BeginContext(686, 3, true);
                WriteLiteral("100");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(698, 258, true);
            WriteLiteral(@"
            </select>
        </div>
        <div class=""col-3"">
            <input class=""form-control"" type=""text"" id=""pesquisa"" name=""pesquisa""
                   placeholder=""Pesquise aqui..."" onkeyup=""Pesquisa()"" />
        </div>
    </div>

");
            EndContext();
#line 31 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(990, 601, true);
            WriteLiteral(@"        <div class=""table-responsive mt-4"" style=""overflow-y: scroll; height: 400px; background-color: #fafafa;"">
            <table id=""cabecalho"" class=""table table-hover"">
                <thead class=""cabecalho"">
                    <tr>
                        <th scope=""col"">Data de pedido</th>
                        <th scope=""col"">Pagamento</th>
                        <th scope=""col"">Situação</th>
                        <th scope=""col"">Valor total</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 45 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1664, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 48 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                              var formaPagamento = item.FormaPagamento == '1' ? "Cartão de crédito" : "Boleto";

#line default
#line hidden
            BeginContext(1808, 44, true);
            WriteLiteral("                            <td width=\"100\">");
            EndContext();
            BeginContext(1853, 36, false);
#line 49 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                       Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1889, 51, true);
            WriteLiteral("</td>\r\n                            <td width=\"100\">");
            EndContext();
            BeginContext(1941, 14, false);
#line 50 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                       Write(formaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1955, 51, true);
            WriteLiteral("</td>\r\n                            <td width=\"100\">");
            EndContext();
            BeginContext(2007, 46, false);
#line 51 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                       Write(PedidoController.SituacaoPedido(item.Situacao));

#line default
#line hidden
            EndContext();
            BeginContext(2053, 51, true);
            WriteLiteral("</td>\r\n                            <td width=\"100\">");
            EndContext();
            BeginContext(2105, 24, false);
#line 52 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                       Write(item.Total.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 86, true);
            WriteLiteral("</td>\r\n                            <td width=\"50\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2215, "\"", 2285, 1);
#line 54 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
WriteAttributeValue("", 2222, Url.Action("Detalhe", "Pedido", new { id = item.IdTransacao }), 2222, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2286, 145, true);
            WriteLiteral(" class=\"btn btn-sm btn-outline-primary\"><i class=\"fa fa-info-circle\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 57 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                    }

#line default
#line hidden
            BeginContext(2454, 64, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 61 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2542, 43, true);
            WriteLiteral("        <p>Nenhum registro encontrado</p>\r\n");
            EndContext();
#line 65 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
    }

#line default
#line hidden
            BeginContext(2592, 34, true);
            WriteLiteral("    <div class=\"text-left mt-3\">\r\n");
            EndContext();
#line 67 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
         if (Model.PageCount > 0)
        {

#line default
#line hidden
            BeginContext(2672, 183, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <small>\r\n                        <strong>\r\n                            Página <label id=\"pagina\">");
            EndContext();
            BeginContext(2856, 16, false);
#line 73 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                                 Write(Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2872, 65, true);
            WriteLiteral("</label> de\r\n                            <label id=\"num-paginas\">");
            EndContext();
            BeginContext(2938, 15, false);
#line 74 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                               Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(2953, 413, true);
            WriteLiteral(@"</label>
                        </strong>
                    </small>
                </div>
                <div class=""col text-right"">
                    <a href=""#cabecalho"">Topo da lista</a>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <small class=""justify-content-end"">
                        <strong>Total de ");
            EndContext();
            BeginContext(3367, 20, false);
#line 85 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                    Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(3387, 95, true);
            WriteLiteral(" registros</strong>\r\n                    </small>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 89 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
        }

#line default
#line hidden
            BeginContext(3493, 30, true);
            WriteLiteral("\r\n        <div class=\"mt-3\">\r\n");
            EndContext();
#line 92 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
             if (Model.PageNumber > 2)
            {

#line default
#line hidden
            BeginContext(3578, 178, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary mr-2\" type=\"button\"\r\n                        onclick=\"AlterarPagina(1)\">\r\n                    1\r\n                </button>\r\n");
            EndContext();
#line 98 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
            }

#line default
#line hidden
            BeginContext(3771, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 99 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
             if (Model.PageNumber > 1)
            {

#line default
#line hidden
            BeginContext(3826, 123, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary\" type=\"button\"\r\n                        onclick=\"AlterarPagina(2)\">\r\n");
            EndContext();
#line 103 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                       var anterior = Model.PageNumber - 1;

#line default
#line hidden
            BeginContext(4009, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4011, 8, false);
#line 103 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                                        Write(anterior);

#line default
#line hidden
            EndContext();
            BeginContext(4019, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 105 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
            }

#line default
#line hidden
            BeginContext(4063, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 106 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
             if (Model.PageCount > 0)
            {

#line default
#line hidden
            BeginContext(4117, 101, true);
            WriteLiteral("                <button class=\"btn btn-outline-primary\" type=\"button\" disabled>\r\n                    ");
            EndContext();
            BeginContext(4219, 16, false);
#line 109 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
               Write(Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4235, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 111 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
            }

#line default
#line hidden
            BeginContext(4279, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 112 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
             if (Model.PageNumber < Model.PageCount)
            {

#line default
#line hidden
            BeginContext(4348, 123, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary\" type=\"button\"\r\n                        onclick=\"AlterarPagina(3)\">\r\n");
            EndContext();
#line 116 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                       var proximo = Model.PageNumber + 1;

#line default
#line hidden
            BeginContext(4530, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4532, 7, false);
#line 116 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
                                                       Write(proximo);

#line default
#line hidden
            EndContext();
            BeginContext(4539, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 118 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
            }

#line default
#line hidden
            BeginContext(4583, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 119 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
             if (Model.PageNumber < Model.PageCount - 1)
            {

#line default
#line hidden
            BeginContext(4656, 148, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary ml-2\" type=\"button\"\r\n                        onclick=\"AlterarPagina(4)\">\r\n                    ");
            EndContext();
            BeginContext(4805, 15, false);
#line 123 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
               Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4820, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 125 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Lista.cshtml"
            }

#line default
#line hidden
            BeginContext(4864, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<LojaVirtual.Models.Venda.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
