#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76a1c0159c73a597e392aa697e59cd99471c024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Detalhe), @"mvc.1.0.view", @"/Views/Pedido/Detalhe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Detalhe.cshtml", typeof(AspNetCore.Views_Pedido_Detalhe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b76a1c0159c73a597e392aa697e59cd99471c024", @"/Views/Pedido/Detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Venda.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Pedido/detalhe.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
  
    ViewData["Title"] = "Detalhe de pedido";

#line default
#line hidden
            BeginContext(96, 63, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4>Detalhe de pedido</h4>\r\n\r\n");
            EndContext();
#line 10 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(191, 822, true);
            WriteLiteral(@"        <div class=""row mt-4"">
            <div class=""col"">
                <h5>Produtos</h5>
            </div>
        </div>
        <div class=""row mt-2"">
            <div class=""col"">
                <div class=""table-responsive shadow"" style=""overflow-y: scroll; height: 200px;"">
                    <table class=""table table-hover"">
                        <thead class=""text-muted"">
                            <tr class=""small text-uppercase"">
                                <th scope=""col"" width=""300"">Produto</th>
                                <th scope=""col"" class=""text-center"" width=""170"">Quantidade</th>
                                <th scope=""col"">Preço</th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>

");
            EndContext();
#line 30 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                         foreach (var produto in Model.Produto)
                        {

#line default
#line hidden
            BeginContext(1105, 106, true);
            WriteLiteral("                            <tr>\r\n                                <td><p class=\"text-muted small\"><strong>");
            EndContext();
            BeginContext(1212, 12, false);
#line 33 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                                   Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 56, true);
            WriteLiteral("</strong></p></td>\r\n                                <td>");
            EndContext();
            BeginContext(1281, 18, false);
#line 34 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                               Write(produto.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 169, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"price-wrap\">\r\n                                        R$ <var class=\"price\">");
            EndContext();
            BeginContext(1469, 45, false);
#line 37 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                         Write(produto.Valor.ToString("C").Replace("R$", ""));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 476, true);
            WriteLiteral(@"</var>
                                        <small class=""text-muted""> /unidade </small>
                                    </div>
                                </td>
                                <td>
                                    <button class=""btn btn-sm btn-outline-primary""><i class=""fa fa-info-circle""></i></button>
                                    <button class=""btn btn-sm btn-outline-secondary"" data-toggle=""modal"" data-target=""#situacao-modal""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1990, "\"", 2036, 3);
            WriteAttributeValue("", 2000, "CarregaSituacao(\'", 2000, 17, true);
#line 43 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
WriteAttributeValue("", 2017, produto.Situacao, 2017, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2034, "\')", 2034, 2, true);
            EndWriteAttribute();
            BeginContext(2037, 118, true);
            WriteLiteral("><i class=\"fa fa-ellipsis-h\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 46 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                        }

#line default
#line hidden
            BeginContext(2182, 90, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(2274, 623, true);
            WriteLiteral(@"        <div class=""row mt-5"">
            <div class=""col text-center"">
                <h5>Situação</h5>
            </div>
        </div>
        <div class=""row mt-2 justify-content-center"">
            <div class=""col-9 text-center"">
                <div class=""progress"" style=""height: 10px;"">
                    <div class=""progress-bar bg-primary"" id=""bar-situacao-pedido"" role=""progressbar"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                </div>
            </div>
        </div>
        <div class=""row mt-2 justify-content-center"">
            <input type=""hidden"" id=""situacao-pedido""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2897, "\"", 2920, 1);
#line 65 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
WriteAttributeValue("", 2905, Model.Situacao, 2905, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2921, 48, true);
            WriteLiteral(" />\r\n            <div class=\"col-3 text-left\">\r\n");
            EndContext();
#line 67 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                 if (Model.FormaPagamento == (byte)Global.Pagamento.CartaoCredito)
                {

#line default
#line hidden
            BeginContext(3072, 53, true);
            WriteLiteral("                    <div>Aguardando pagamento</div>\r\n");
            EndContext();
#line 70 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3185, 54, true);
            WriteLiteral("                    <div>Processando pagamento</div>\r\n");
            EndContext();
#line 74 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                }

#line default
#line hidden
            BeginContext(3258, 729, true);
            WriteLiteral(@"                <button class=""btn btn-outline-light"" id=""btn-aguardo"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
            </div>
            <div class=""col-3 text-center"">
                <div>Aprovado</div>
                <button class=""btn btn-outline-light"" id=""btn-pedido-aprovado"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
            </div>
            <div class=""col-3 text-right"">
                <div>Finalizado</div>
                <button class=""btn btn-outline-light"" id=""btn-finalizado"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
            </div>
        </div>
");
            EndContext();
            BeginContext(3989, 509, true);
            WriteLiteral(@"        <div class=""row mt-3"">
            <div class=""col text-center"">
                <h5>Informações sobre o pedido</h5>
            </div>
        </div>
        <div class=""row mt-2"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""row"" width=""200"">Endereço de entrega</th>
                        <td scope=""col"" colspan=""1"" width=""180"">
                            <strong>CEP:</strong> <text class=""cep"">");
            EndContext();
            BeginContext(4499, 18, false);
#line 98 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                               Write(Model.Endereco.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(4517, 128, true);
            WriteLiteral("</text>\r\n                        </td>\r\n                        <td scope=\"col\" colspan=\"2\">\r\n                            <text>");
            EndContext();
            BeginContext(4646, 25, false);
#line 101 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                             Write(Model.Endereco.Logradouro);

#line default
#line hidden
            EndContext();
            BeginContext(4671, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(4674, 21, false);
#line 101 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                         Write(Model.Endereco.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(4695, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(4699, 21, false);
#line 101 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                                                  Write(Model.Endereco.Bairro);

#line default
#line hidden
            EndContext();
            BeginContext(4720, 211, true);
            WriteLiteral("</text>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\" width=\"100\">Frete</th>\r\n                        <td scope=\"col\" colspan=\"1\">\r\n");
            EndContext();
#line 107 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                              var servico = Model.Frete.Servico == '1' ? "Sedex" : "Pac";

#line default
#line hidden
            BeginContext(5023, 60, true);
            WriteLiteral("                            <strong>Serviço:</strong> <text>");
            EndContext();
            BeginContext(5084, 7, false);
#line 108 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                       Write(servico);

#line default
#line hidden
            EndContext();
            BeginContext(5091, 164, true);
            WriteLiteral("</text>\r\n                        </td>\r\n                        <td scope=\"col\" colspan=\"1\" width=\"200\">\r\n                            <strong>Valor:</strong> <text>");
            EndContext();
            BeginContext(5256, 31, false);
#line 111 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                     Write(Model.Frete.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5287, 227, true);
            WriteLiteral("</text>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\" width=\"100\">Pagamento</th>\r\n                        <td scope=\"col\" colspan=\"1\" width=\"300\">\r\n");
            EndContext();
#line 117 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                              var formaPagamento = Model.FormaPagamento == (byte)Global.Pagamento.CartaoCredito ? "Cartão de crédito" : "Boleto";

#line default
#line hidden
            BeginContext(5662, 59, true);
            WriteLiteral("                            <strong>Método:</strong> <text>");
            EndContext();
            BeginContext(5722, 14, false);
#line 118 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                      Write(formaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(5736, 40, true);
            WriteLiteral("</text>\r\n                        </td>\r\n");
            EndContext();
#line 120 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                         if (Model.FormaPagamento == (byte)Global.Pagamento.CartaoCredito)
                        {

#line default
#line hidden
            BeginContext(5895, 145, true);
            WriteLiteral("                            <td scope=\"col\" colspan=\"1\" width=\"300\">\r\n                                <strong>Número de parcelas:</strong> <text>");
            EndContext();
            BeginContext(6041, 27, false);
#line 123 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                                      Write(Model.Parcelamento.Parcelas);

#line default
#line hidden
            EndContext();
            BeginContext(6068, 4, true);
            WriteLiteral(" de ");
            EndContext();
            BeginContext(6073, 45, false);
#line 123 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                                                                      Write(Model.Parcelamento.ValorParcela.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6118, 170, true);
            WriteLiteral("</text>\r\n                            </td>\r\n                            <td scope=\"col\" colspan=\"1\">\r\n                                <strong>Valor total:</strong> <text>");
            EndContext();
            BeginContext(6289, 25, false);
#line 126 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                               Write(Model.Total.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6314, 44, true);
            WriteLiteral("</text>\r\n                            </td>\r\n");
            EndContext();
#line 128 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6442, 126, true);
            WriteLiteral("                            <td scope=\"col\" colspan=\"1\">\r\n                                <strong>Valor total:</strong> <text>");
            EndContext();
            BeginContext(6569, 25, false);
#line 132 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                                                               Write(Model.Total.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6594, 172, true);
            WriteLiteral("</text>\r\n                            </td>\r\n                            <td scope=\"col\" colspan=\"1\">\r\n                                <strong>Visualizar boleto:</strong> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6766, "\"", 6790, 1);
#line 135 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
WriteAttributeValue("", 6773, Model.Boleto.Url, 6773, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6791, 62, true);
            WriteLiteral(" target=\"_blank\">Aqui</a>\r\n                            </td>\r\n");
            EndContext();
#line 137 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
                        }

#line default
#line hidden
            BeginContext(6880, 91, true);
            WriteLiteral("                    </tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 142 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(6995, 87, true);
            WriteLiteral("        <div class=\"mt-5\">\r\n            <p>Pedido não encontrado.</p>\r\n        </div>\r\n");
            EndContext();
#line 148 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Pedido\Detalhe.cshtml"
    }

#line default
#line hidden
            BeginContext(7089, 2864, true);
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""situacao-modal"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Situação atual de produto</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row mt-3 justify-content-center"">
                    <div class=""col-8 text-center"">
                        <div class=""progress"" style=""height: 10px;"">
                            <div class=""progress-bar bg-primary"" id=""bar-situacao-produto"" role=""progressbar"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2 justify-content-center"" id=""div-s");
            WriteLiteral(@"ituacao"">
                    <div class=""col-2 text-left"">
                        <div>Em espera</div>
                        <button class=""btn btn-outline-light"" id=""btn-espera"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
                    </div>
                    <div class=""col-2 text-center"">
                        <div>Pagamento aprovado</div>
                        <button class=""btn btn-outline-light"" id=""btn-aprovado"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
                    </div>
                    <div class=""col-2 text-right"">
                        <div>Enviado</div>
                        <button class=""btn btn-outline-light"" id=""btn-enviado"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
                    </div>
                    <div class=""col-2 text-right"">
                        <div>Entregue</div>
                        <butto");
            WriteLiteral(@"n class=""btn btn-outline-light"" id=""btn-entregue"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-check-circle""></i></button>
                    </div>
                </div>
                <div class=""row mt-2 justify-content-center d-none"" id=""div-cancelado"">
                    <div class=""col text-center"">
                        <div>Cancelado</div>
                        <button class=""btn btn-outline-light"" id=""btn-cancelado"" style=""border-color: white"" disabled><i class=""fa fa-lg fa-times""></i></button>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-primary"" data-dismiss=""modal"">Voltar</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(9953, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f2bb55ed1842e793fbf5823854ec4e", async() => {
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
            BeginContext(10005, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10007, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5f6a400c0644a291cb4209631d6624", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Venda.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
