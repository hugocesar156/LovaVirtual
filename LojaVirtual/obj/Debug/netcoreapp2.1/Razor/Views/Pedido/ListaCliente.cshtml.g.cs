#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fd35305df10f87ecb27f1293d20b61b27cfad8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_ListaCliente), @"mvc.1.0.view", @"/Views/Pedido/ListaCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/ListaCliente.cshtml", typeof(AspNetCore.Views_Pedido_ListaCliente))]
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
#line 2 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
using LojaVirtual.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd35305df10f87ecb27f1293d20b61b27cfad8b", @"/Views/Pedido/ListaCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_ListaCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<LojaVirtual.Models.Venda.Pedido>>
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
#line 4 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "276349fe79ff41a6b199caf491a1dc50", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9b9a1d918c14cf686612f7caad1ceea", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c215b36cb61f4897bd6f0c503f5793f6", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c49fef42eb14600b665572439c81e14", async() => {
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
#line 31 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(990, 561, true);
            WriteLiteral(@"        <div class=""table-responsive shadow mt-4"" style=""overflow-y: scroll; height: 400px;"">
            <table id=""cabecalho"" class=""table table-hover"">
                <thead class=""cabecalho"" style=""background-color: #f7f3f3;"">
                    <tr>
                        <th scope=""col"">Data de pedido</th>
                        <th scope=""col"">Pagamento</th>
                        <th scope=""col"">Valor total</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 44 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1624, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 47 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                              var formaPagamento = item.FormaPagamento == (byte)Global.Pagamento.CartaoCredito ? "Cartão de crédito" : "Boleto";

#line default
#line hidden
            BeginContext(1801, 44, true);
            WriteLiteral("                            <td width=\"100\">");
            EndContext();
            BeginContext(1846, 36, false);
#line 48 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                       Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1882, 51, true);
            WriteLiteral("</td>\r\n                            <td width=\"100\">");
            EndContext();
            BeginContext(1934, 14, false);
#line 49 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                       Write(formaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 51, true);
            WriteLiteral("</td>\r\n                            <td width=\"100\">");
            EndContext();
            BeginContext(2000, 24, false);
#line 50 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                       Write(item.Total.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 86, true);
            WriteLiteral("</td>\r\n                            <td width=\"50\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2110, "\"", 2180, 1);
#line 52 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
WriteAttributeValue("", 2117, Url.Action("Detalhe", "Pedido", new { id = item.IdTransacao }), 2117, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2181, 145, true);
            WriteLiteral(" class=\"btn btn-sm btn-outline-primary\"><i class=\"fa fa-info-circle\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 55 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                    }

#line default
#line hidden
            BeginContext(2349, 64, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 59 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2437, 43, true);
            WriteLiteral("        <p>Nenhum registro encontrado</p>\r\n");
            EndContext();
#line 63 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
    }

#line default
#line hidden
            BeginContext(2487, 34, true);
            WriteLiteral("    <div class=\"text-left mt-3\">\r\n");
            EndContext();
#line 65 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
         if (Model.PageCount > 0)
        {

#line default
#line hidden
            BeginContext(2567, 183, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <small>\r\n                        <strong>\r\n                            Página <label id=\"pagina\">");
            EndContext();
            BeginContext(2751, 16, false);
#line 71 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                                 Write(Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2767, 65, true);
            WriteLiteral("</label> de\r\n                            <label id=\"num-paginas\">");
            EndContext();
            BeginContext(2833, 15, false);
#line 72 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                               Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 413, true);
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
            BeginContext(3262, 20, false);
#line 83 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                    Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(3282, 95, true);
            WriteLiteral(" registros</strong>\r\n                    </small>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 87 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
        }

#line default
#line hidden
            BeginContext(3388, 30, true);
            WriteLiteral("\r\n        <div class=\"mt-3\">\r\n");
            EndContext();
#line 90 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
             if (Model.PageNumber > 2)
            {

#line default
#line hidden
            BeginContext(3473, 178, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary mr-2\" type=\"button\"\r\n                        onclick=\"AlterarPagina(1)\">\r\n                    1\r\n                </button>\r\n");
            EndContext();
#line 96 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
            }

#line default
#line hidden
            BeginContext(3666, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 97 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
             if (Model.PageNumber > 1)
            {

#line default
#line hidden
            BeginContext(3721, 123, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary\" type=\"button\"\r\n                        onclick=\"AlterarPagina(2)\">\r\n");
            EndContext();
#line 101 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                       var anterior = Model.PageNumber - 1;

#line default
#line hidden
            BeginContext(3904, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3906, 8, false);
#line 101 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                                        Write(anterior);

#line default
#line hidden
            EndContext();
            BeginContext(3914, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 103 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
            }

#line default
#line hidden
            BeginContext(3958, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 104 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
             if (Model.PageCount > 0)
            {

#line default
#line hidden
            BeginContext(4012, 101, true);
            WriteLiteral("                <button class=\"btn btn-outline-primary\" type=\"button\" disabled>\r\n                    ");
            EndContext();
            BeginContext(4114, 16, false);
#line 107 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
               Write(Model.PageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4130, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 109 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
            }

#line default
#line hidden
            BeginContext(4174, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 110 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
             if (Model.PageNumber < Model.PageCount)
            {

#line default
#line hidden
            BeginContext(4243, 123, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary\" type=\"button\"\r\n                        onclick=\"AlterarPagina(3)\">\r\n");
            EndContext();
#line 114 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                       var proximo = Model.PageNumber + 1;

#line default
#line hidden
            BeginContext(4425, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4427, 7, false);
#line 114 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
                                                       Write(proximo);

#line default
#line hidden
            EndContext();
            BeginContext(4434, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 116 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
            }

#line default
#line hidden
            BeginContext(4478, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 117 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
             if (Model.PageNumber < Model.PageCount - 1)
            {

#line default
#line hidden
            BeginContext(4551, 148, true);
            WriteLiteral("                <button class=\"btn btn-sm btn-primary ml-2\" type=\"button\"\r\n                        onclick=\"AlterarPagina(4)\">\r\n                    ");
            EndContext();
            BeginContext(4700, 15, false);
#line 121 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
               Write(Model.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4715, 29, true);
            WriteLiteral("\r\n                </button>\r\n");
            EndContext();
#line 123 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\ListaCliente.cshtml"
            }

#line default
#line hidden
            BeginContext(4759, 34, true);
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
