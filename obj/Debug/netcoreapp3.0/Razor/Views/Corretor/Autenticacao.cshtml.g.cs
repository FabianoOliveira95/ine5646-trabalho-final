#pragma checksum "C:\Users\Fabiano\Downloads\AmbienteSD\AmbienteSD\SuddenAmbiente\Views\Corretor\Autenticacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca005f5d73321411c3c167ef304ba19917190f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Corretor_Autenticacao), @"mvc.1.0.view", @"/Views/Corretor/Autenticacao.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Fabiano\Downloads\AmbienteSD\AmbienteSD\SuddenAmbiente\Views\_ViewImports.cshtml"
using SuddenAmbiente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabiano\Downloads\AmbienteSD\AmbienteSD\SuddenAmbiente\Views\_ViewImports.cshtml"
using SuddenAmbiente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca005f5d73321411c3c167ef304ba19917190f1", @"/Views/Corretor/Autenticacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fae81c3e10b43816b6cf0e78a28d369184ea291", @"/Views/_ViewImports.cshtml")]
    public class Views_Corretor_Autenticacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Corretor/CadastrarCorretor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"<!-- Content Header (Page header) -->
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">Entre com sua conta de corretor</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">Imóveis</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<div class=""callout callout-info"" style=""margin-left: 2%; max-width: 92%"">
    <div class=""card-body"" style=""padding: 1rem"">
        <div class=""form-group"">
            <label for=""Email"">Email</label>
            <div class=""input-group"">
                <input type=""email"" name=""Email"" id=""Email"" placeholder=""Escreva seu e-mail"" required=""required"" />
      ");
            WriteLiteral(@"      </div>
        </div>
        <div class=""form-group"">
            <label for=""Senha"">Senha</label>
            <div class=""input-group"">
                <input type=""password"" name=""Senha"" id=""Senha"" placeholder=""Escreva sua senha"" required=""required"" />
            </div>
        </div>
    </div>
    <!-- /.card-body -->

    <div class=""card-footer"">
        <button id=""confirm"" class=""btn btn-primary"">Entrar</button>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca005f5d73321411c3c167ef304ba19917190f15119", async() => {
                WriteLiteral("Não tem uma conta corretor? Clique aqui");
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
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                BeginWriteAttribute("src", " src=\"", 1654, "\"", 1703, 1);
#nullable restore
#line 43 "C:\Users\Fabiano\Downloads\AmbienteSD\AmbienteSD\SuddenAmbiente\Views\Corretor\Autenticacao.cshtml"
WriteAttributeValue("", 1660, Url.Content("~/lib/jquery/dist/jquery.js"), 1660, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#confirm\').click(function () {\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \'");
#nullable restore
#line 50 "C:\Users\Fabiano\Downloads\AmbienteSD\AmbienteSD\SuddenAmbiente\Views\Corretor\Autenticacao.cshtml"
                     Write(Url.Action("Autenticar", "Corretor"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    data: { email: $('#Email').val(), senha: $('#Senha').val() },
                    success: function (response) {
                        if (response !== '') {
                            $('#NomeCorretor').html(response.nomeCorretor);
                            window.location.href = response.redirectToUrl;
                        } else {
                            alert(""Email ou senha incorreta!"")
                        }
                    },
                    error: function () { alert('Ocorreu um erro inesperado!'); }
                });
    });

});
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591