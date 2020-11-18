#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef0ed79f46b48ba8e38df109d25e8ae08f31a5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho__Carrinho), @"mvc.1.0.view", @"/Views/Carrinho/_Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/_Carrinho.cshtml", typeof(AspNetCore.Views_Carrinho__Carrinho))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0ed79f46b48ba8e38df109d25e8ae08f31a5d", @"/Views/Carrinho/_Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b6397a813ab2e3f29c2c4626f1b3aa86fa5744", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho__Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LojaVirtual.Models.Produto.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
 foreach (var produto in Model)
{

#line default
#line hidden
            BeginContext(87, 63, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            <figure class=\"itemside\">\r\n");
            EndContext();
#line 8 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
                  var imagem = produto.Imagem != null && produto.Imagem.Count > 0 ? produto.Imagem.FirstOrDefault().Caminho.Replace("wwwroot", "") : "";

#line default
#line hidden
            BeginContext(305, 39, true);
            WriteLiteral("                <div class=\"aside\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 344, "\"", 357, 1);
#line 9 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 350, imagem, 350, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 263, true);
            WriteLiteral(@" width=""70"" height=""70"" class=""img-sm""></div>
            </figure>
        </td>
        <td>
            <figure class=""itemside"">
                <figcaption class=""info"">
                    <p class=""text-muted small"">
                        <strong>");
            EndContext();
            BeginContext(622, 12, false);
#line 16 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
                           Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(634, 402, true);
            WriteLiteral(@"</strong>
                    </p>
                </figcaption>
            </figure>
        </td>
        <td>
            <div class=""row"">
                <div class=""col"">
                    <div class=""input-group mb-3 input-spinner"">
                        <div class=""input-group-prepend"">
                            <button class=""btn btn-outline-dark"" id=""remover"" type=""button""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1036, "\"", 1083, 3);
            WriteAttributeValue("", 1046, "RetirarQuantidade(", 1046, 18, true);
#line 26 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 1064, produto.IdProduto, 1064, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1082, ")", 1082, 1, true);
            EndWriteAttribute();
            BeginContext(1084, 110, true);
            WriteLiteral("> − </button>\r\n                        </div>\r\n                        <input type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1194, "\"", 1240, 1);
#line 28 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 1202, ViewBag.Quantidade[produto.IdProduto], 1202, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1241, 186, true);
            WriteLiteral(" readonly style=\"text-align: center;\">\r\n                        <div class=\"input-group-append\">\r\n                            <button class=\"btn btn-outline-dark adicionar\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1427, "\"", 1476, 3);
            WriteAttributeValue("", 1437, "AdicionarQuantidade(", 1437, 20, true);
#line 30 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 1457, produto.IdProduto, 1457, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1475, ")", 1475, 1, true);
            EndWriteAttribute();
            BeginContext(1477, 224, true);
            WriteLiteral("> + </button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </td>\r\n        <td>\r\n            <div class=\"price-wrap\">\r\n                R$ <var class=\"price\">");
            EndContext();
            BeginContext(1702, 46, false);
#line 38 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
                                 Write(produto.Valor.ToString("C").Replace("R$ ", ""));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 122, true);
            WriteLiteral("</var>\r\n                <small class=\"text-muted\"> /unidade </small>\r\n                <input type=\"hidden\" id=\"quantidade\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1870, "\"", 1916, 1);
#line 40 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 1878, ViewBag.Quantidade[produto.IdProduto], 1878, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1917, 142, true);
            WriteLiteral(" />\r\n            </div>\r\n        </td>\r\n        <td class=\"text-right\">\r\n            <button type=\"button\" class=\"btn btn-sm btn-outline-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2059, "\"", 2100, 3);
            WriteAttributeValue("", 2069, "RemoverItem(", 2069, 12, true);
#line 44 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
WriteAttributeValue("", 2081, produto.IdProduto, 2081, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2099, ")", 2099, 1, true);
            EndWriteAttribute();
            BeginContext(2101, 66, true);
            WriteLiteral("> <i class=\"fa fa-trash\"></i></button>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 47 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Carrinho\_Carrinho.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LojaVirtual.Models.Produto.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591