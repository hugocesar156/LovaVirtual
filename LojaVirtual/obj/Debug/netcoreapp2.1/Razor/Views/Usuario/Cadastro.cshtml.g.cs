#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677e73be884d29f0a93aa43901b770db333498b9"
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
#line 4 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Sessions;

#line default
#line hidden
#line 5 "C:\Projetos\Loja Virtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Validations;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677e73be884d29f0a93aa43901b770db333498b9", @"/Views/Usuario/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Acesso.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-endereco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario/validacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Endereco/endereco.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro de usuário";

#line default
#line hidden
            BeginContext(99, 67, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4>Cadastro de usuário</h4>\r\n    ");
            EndContext();
            BeginContext(166, 2908, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b458a2f07c94d348a0d6de1a378b1fe", async() => {
                BeginContext(190, 365, true);
                WriteLiteral(@"
        <h5 class=""mt-4"">Cliente</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Nome</label>
                <input class=""form-control form-cliente"" id=""nome"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 555, "\"", 582, 1);
#line 15 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 563, Model.Cliente.Nome, 563, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(583, 336, true);
                WriteLiteral(@"/>
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-2 text-center mt-2 mt-md-0"">
                <label>CPF</label>
                <input class=""form-control form-cliente cpf"" id=""cpf"" type=""text"" placeholder=""000.000.000-00"" 
                       style=""text-align: center"" onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 919, "\"", 945, 1);
#line 20 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 927, Model.Cliente.Cpf, 927, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(946, 464, true);
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
                BeginContext(1411, 136, true);
                WriteLiteral("@</span>\r\n                    </div>\r\n                    <input class=\"form-control form-cliente\" id=\"email\" type=\"text\" maxlength=\"35\"");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                           placeholder=\"", 1547, "\"", 1607, 3);
                WriteAttributeValue("", 1589, "exemplo", 1589, 7, true);
                WriteAttributeValue("", 1596, "@", 1596, 1, true);
                WriteAttributeValue("", 1598, "email.com", 1598, 9, true);
                EndWriteAttribute();
                BeginContext(1608, 84, true);
                WriteLiteral(" style=\"text-align: center\"\r\n                           onchange=\"ValidaCampo(this)\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1692, "\"", 1712, 1);
#line 33 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 1700, Model.Email, 1700, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1713, 553, true);
                WriteLiteral(@" />
                    <div class=""invalid-feedback text-left"" id=""email""></div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-9 col-sm-7 col-md-4 col-xl-3 text-center text-md-left"">
                <label>Senha</label>
                <input class=""form-control form-cliente senha"" id=""senha"" type=""password"" maxlength=""30""
                       placeholder=""*******"" style=""text-align: center"" 
                       onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2266, "\"", 2286, 1);
#line 43 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
WriteAttributeValue("", 2274, Model.Senha, 2274, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2287, 780, true);
                WriteLiteral(@" />
                <div class=""invalid-feedback text-left msg-senha"" id=""senha""></div>
            </div>
            <div class=""col-9 col-sm-7 col-md-4 col-xl-3 text-center text-md-left mt-2 mt-md-0"">
                <label>Confirme sua senha</label>
                <input class=""form-control form-cliente conf"" id=""confirma"" type=""password"" maxlength=""30""
                       style=""text-align: center"" onchange=""ValidaCampo(this)"" />
                <div class=""invalid-feedback text-left msg-conf"" id=""confirma""></div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-success col-6 col-sm-5 col-md-3"" type=""button"" onclick=""ValidaUsuario()"">Contiuar</button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3074, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(3082, 4712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3ad8fbb5d646d7b3adca0970befa93", async() => {
                BeginContext(3122, 2164, true);
                WriteLiteral(@"
        <h5 class=""mt-4"">Endereço</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-2 text-center text-md-left"">
                <label>CEP</label>
                <input class=""form-control form-endereco cep"" id=""cep"" type=""text"" maxlength=""50""
                       placeholder=""00000-000"" style=""text-align: center;"" onchange=""BuscaEndereco()"" value="""" />
                <div class=""invalid-feedback text-left"" id=""cpf"">Insira um CEP válido</div>
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-4 text-left mt-2 mt-md-0"">
                <label>Logradouro</label>
                <input class=""form-control form-endereco"" id=""logradouro"" type=""text""
                       onchange=""ValidaCampoEndereco(this)"" />
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-2 text-left mt-2 mt-md-0"">
                <label>Número</label>
                <input class=""form-control form-endereco"" i");
                WriteLiteral(@"d=""numero"" type=""text"" placeholder=""000""
                       maxlength=""5"" style=""text-align: center"" onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Bairro</label>
                <input class=""form-control form-endereco"" id=""bairro"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Cidade</label>
                <input class=""form-control form-endereco"" id=""cidade"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-2 text-center text-md-left"">
                <label>UF</label>
                <select ");
                WriteLiteral("id=\"uf\" class=\"custom-select form-control form-endereco\" onchange=\"ValidaCampoEndereco(this)\">\r\n                    ");
                EndContext();
                BeginContext(5286, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7899bfbf9844723b8d3f3a9120a7771", async() => {
                    BeginContext(5312, 2, true);
                    WriteLiteral("--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                BeginContext(5323, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 94 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
                     foreach (var uf in ViewBag.Estados)
                    {

#line default
#line hidden
                BeginContext(5408, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(5432, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bef625dd0fe49c0a82ca16591faf936", async() => {
                    BeginContext(5453, 2, false);
#line 96 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
                                       Write(uf);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 96 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
                           WriteLiteral(uf);

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
                BeginContext(5464, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 97 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Cadastro.cshtml"
                    }

#line default
#line hidden
                BeginContext(5489, 2298, true);
                WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""row justify-content-center mt-4 "">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Nome de endereço</label>
                <input class=""form-control form-endereco"" id=""nome-endereco"" type=""text"" maxlength=""50""
                       style=""text-align: center"" onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Complemento</label>
                <input class=""form-control form-endereco campo-nulo"" id=""complemento"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
        </div>
        <h5 class=""mt-5"">Contato</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-5 text-center text-md-left"">
            ");
                WriteLiteral(@"    <label>Nome do contato</label>
                <input class=""form-control form-contato"" id=""nome-contato"" type=""text"" maxlength=""50""
                       placeholder=""Pessoal, familiar, trabalho"" onchange=""ValidaCampo(this)"" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Número</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">#</span>
                    </div>
                    <input class=""form-control form-contato telefone"" id=""numero-contato"" type=""text"" maxlength=""50"" placeholder=""00 00000-0000""
                           style=""text-align: center;"" onchange=""ValidaCampo(this)"" />
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-outline-success col-6 col-sm-5 col-md-3"" type=""button"" onclick");
                WriteLiteral("=\"Voltar()\">Voltar</button>\r\n        </div>\r\n        <div class=\"row justify-content-center mb-3\">\r\n            <button class=\"btn btn-success col-6 col-sm-5 col-md-3\" type=\"button\" onclick=\"RegistraUsuario()\">Finalizar</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7794, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(7806, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d69b2098c945d0ad361033f5d5c455", async() => {
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
            BeginContext(7855, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(7857, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e6657be45442e9990603cc79fa6a54", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
