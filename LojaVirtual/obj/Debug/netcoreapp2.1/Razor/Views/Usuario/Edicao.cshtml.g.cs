#pragma checksum "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ebab7cc2b7cf09e1068c9fe752af447153813d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Edicao), @"mvc.1.0.view", @"/Views/Usuario/Edicao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Edicao.cshtml", typeof(AspNetCore.Views_Usuario_Edicao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ebab7cc2b7cf09e1068c9fe752af447153813d", @"/Views/Usuario/Edicao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db735d035cec3189dc33b803c523a739005925cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Edicao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Acesso.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-endereco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario/validacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Endereco/endereco.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario/edicao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
  
    ViewData["Title"] = "Edição de usuário";

#line default
#line hidden
            BeginContext(97, 65, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4>Edição de usuário</h4>\r\n    ");
            EndContext();
            BeginContext(162, 3782, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "936eff7fe34345e0ba3c7e7614a1d79f", async() => {
                BeginContext(186, 365, true);
                WriteLiteral(@"
        <h5 class=""mt-4"">Cliente</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-6 text-center text-md-left"">
                <label>Nome</label>
                <input class=""form-control form-cliente"" id=""nome"" type=""text"" maxlength=""50""
                       onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 551, "\"", 578, 1);
#line 15 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 559, Model.Cliente.Nome, 559, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(579, 407, true);
                WriteLiteral(@" />
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-5 col-sm-4 col-md-3 col-xl-3 text-center mt-2 mt-md-0"">
                <label>CPF</label>
                <input class=""form-control form-cliente cpf"" id=""cpf"" type=""text"" placeholder=""000.000.000-00""
                       style=""text-align: center"" onchange=""ValidaCampo(this)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 986, "\"", 1012, 1);
#line 22 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 994, Model.Cliente.Cpf, 994, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1013, 639, true);
                WriteLiteral(@" />
                <div class=""invalid-feedback text-left"" id=""cpf"">Insira um CPF válido</div>
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-3 text-center mt-2 mt-md-0"">
                <label>Data de nascimento</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text""><i class=""fa fa-calendar""></i></span>
                    </div>
                    <input class=""form-control form-cliente nascimento"" id=""nascimento"" type=""text"" maxlength=""35""
                           placeholder=""dd/mm/aa""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1652, "\"", 1685, 1);
#line 32 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 1660, Model.Cliente.Nascimento, 1660, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1686, 563, true);
                WriteLiteral(@" style=""text-align: center""
                           onchange=""ValidaCampo(this)"" />
                    <div class=""invalid-feedback text-left"" id=""nascimento""></div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-9 col-sm-8 col-md-8 col-xl-6 text-center"">
                <label>Endereço de Email</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">");
                EndContext();
                BeginContext(2250, 136, true);
                WriteLiteral("@</span>\r\n                    </div>\r\n                    <input class=\"form-control form-cliente\" id=\"email\" type=\"text\" maxlength=\"35\"");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                           placeholder=\"", 2386, "\"", 2446, 3);
                WriteAttributeValue("", 2428, "exemplo", 2428, 7, true);
                WriteAttributeValue("", 2435, "@", 2435, 1, true);
                WriteAttributeValue("", 2437, "email.com", 2437, 9, true);
                EndWriteAttribute();
                BeginContext(2447, 84, true);
                WriteLiteral(" style=\"text-align: center\"\r\n                           onchange=\"ValidaCampo(this)\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2531, "\"", 2551, 1);
#line 47 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 2539, Model.Email, 2539, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2552, 552, true);
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
                BeginWriteAttribute("value", " value=\"", 3104, "\"", 3124, 1);
#line 57 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 3112, Model.Senha, 3112, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3125, 782, true);
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
            <button class=""btn btn-info col-6 col-sm-5 col-md-3"" type=""button"" onclick=""ValidaUsuario(2)"">Contiuar</button>
        </div>
        ");
                EndContext();
                BeginContext(3908, 23, false);
#line 70 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3931, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(3944, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(3952, 5355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f74bdb21e61a4ccea5fe0b439ab152a9", async() => {
                BeginContext(3992, 364, true);
                WriteLiteral(@"
        <h5 class=""mt-4"">Endereço</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-2 text-center text-md-left"">
                <label>CEP</label>
                <input class=""form-control form-endereco cep"" id=""cep"" type=""text"" maxlength=""50""
                       placeholder=""00000-000""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4356, "\"", 4391, 1);
#line 79 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 4364, Model.Cliente.Endereco.Cep, 4364, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4392, 393, true);
                WriteLiteral(@" style=""text-align: center;"" onchange=""BuscaEndereco()"" value="""" />
                <div class=""invalid-feedback text-left"" id=""cpf"">Insira um CEP válido</div>
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-4 text-left mt-2 mt-md-0"">
                <label>Logradouro</label>
                <input class=""form-control form-endereco"" id=""logradouro"" type=""text""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 4785, "\"", 4851, 1);
#line 85 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 4817, Model.Cliente.Endereco.Logradouro, 4817, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4852, 283, true);
                WriteLiteral(@" onchange=""ValidaCampoEndereco(this)"" />
            </div>
            <div class=""col-5 col-sm-4 col-md-3 col-xl-2 text-left mt-2 mt-md-0"">
                <label>Número</label>
                <input class=""form-control form-endereco"" id=""numero"" type=""text"" placeholder=""000""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 5135, "\"", 5197, 1);
#line 90 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 5167, Model.Cliente.Endereco.Numero, 5167, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5198, 404, true);
                WriteLiteral(@" maxlength=""5"" style=""text-align: center"" onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
        </div>
        <div class=""row justify-content-center mt-4"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Bairro</label>
                <input class=""form-control form-endereco"" id=""bairro"" type=""text"" maxlength=""50""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 5602, "\"", 5664, 1);
#line 97 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 5634, Model.Cliente.Endereco.Bairro, 5634, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5665, 292, true);
                WriteLiteral(@" onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Cidade</label>
                <input class=""form-control form-endereco"" id=""cidade"" type=""text"" maxlength=""50""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 5957, "\"", 6019, 1);
#line 102 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 5989, Model.Cliente.Endereco.Cidade, 5989, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6020, 332, true);
                WriteLiteral(@" onchange=""ValidaCampoEndereco(this)"" value="""" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-2 text-center text-md-left"">
                <label>UF</label>
                <select id=""uf"" class=""custom-select form-control form-endereco"" onchange=""ValidaCampoEndereco(this)"">
                    ");
                EndContext();
                BeginContext(6352, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "818f861b79bc49f4b26f738c57445809", async() => {
                    BeginContext(6378, 2, true);
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
                BeginContext(6389, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 109 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                     foreach (var uf in ViewBag.Estados)
                    {
                        if (Model.Cliente.Endereco.Uf == uf)
                        {

#line default
#line hidden
                BeginContext(6563, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(6591, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59ff9c3ad4ba439a9b00e24e5f20725d", async() => {
                    BeginContext(6621, 2, false);
#line 113 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                                                    Write(uf);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 113 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                               WriteLiteral(uf);

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
                BeginContext(6632, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 114 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(6718, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(6746, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28934d70b7f34a1399a2c36e1676e7ef", async() => {
                    BeginContext(6767, 2, false);
#line 117 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                                           Write(uf);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 117 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
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
                BeginContext(6778, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 118 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(6830, 357, true);
                WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""row justify-content-center mt-4 "">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Nome de endereço</label>
                <input class=""form-control form-endereco"" id=""nome-endereco"" type=""text"" maxlength=""50""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 7187, "\"", 7247, 1);
#line 127 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 7219, Model.Cliente.Endereco.Nome, 7219, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7248, 330, true);
                WriteLiteral(@" style=""text-align: center"" onchange=""ValidaCampoEndereco(this)""/>
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-4 text-center text-md-left"">
                <label>Complemento</label>
                <input class=""form-control form-endereco campo-nulo"" id=""complemento"" type=""text"" maxlength=""50""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 7578, "\"", 7645, 1);
#line 132 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 7610, Model.Cliente.Endereco.Complemento, 7610, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7646, 406, true);
                WriteLiteral(@" onchange=""ValidaCampoEndereco(this)""/>
            </div>
        </div>
        <h5 class=""mt-5"">Contato</h5>
        <div class=""row justify-content-center mt-2"">
            <div class=""col-10 col-sm-9 col-md-5 col-xl-5 text-center text-md-left"">
                <label>Nome do contato</label>
                <input class=""form-control form-contato"" id=""nome-contato"" type=""text"" maxlength=""50""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                       value=\"", 8052, "\"", 8114, 1);
#line 140 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 8084, Model.Cliente.Contato[0].Nome, 8084, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8115, 556, true);
                WriteLiteral(@" placeholder=""Pessoal, familiar, trabalho"" onchange=""ValidaCampo(this)"" />
            </div>
            <div class=""col-10 col-sm-9 col-md-5 col-xl-3 text-center text-md-left"">
                <label>Número</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">#</span>
                    </div>
                    <input class=""form-control form-contato telefone"" id=""numero-contato"" type=""text"" maxlength=""50"" placeholder=""00 00000-0000""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 8671, "\"", 8739, 1);
#line 149 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
WriteAttributeValue("", 8707, Model.Cliente.Contato[0].Numero, 8707, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8740, 530, true);
                WriteLiteral(@" style=""text-align: center;"" onchange=""ValidaCampo(this)"" />
                </div>
            </div>
        </div>
        <div class=""row justify-content-center mt-5 mb-3"">
            <button class=""btn btn-info col-6 col-sm-5 col-md-3"" type=""button"" onclick=""RegistraUsuario(2)"">Finalizar</button>
        </div>
        <div class=""row justify-content-center mb-3"">
            <button class=""btn btn-outline-danger col-6 col-sm-5 col-md-3"" type=""button"" onclick=""Voltar()"">Voltar</button>
        </div>
        ");
                EndContext();
                BeginContext(9271, 23, false);
#line 159 "C:\Projetos\Loja Virtual\LojaVirtual\Views\Usuario\Edicao.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(9294, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(9307, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(9319, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0de86b15b344ea98f1a5c776bf412af", async() => {
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
            BeginContext(9371, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9373, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f4e0a5c82e24edc9e6744719ad11826", async() => {
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
            BeginContext(9422, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9424, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56553fd0dc354ea993003ce30e8fef02", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9473, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9475, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb3f108da36b4f09983cfbcb03d7f894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
